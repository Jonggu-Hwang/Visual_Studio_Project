using OpenCvSharp;
using System;
using System.Threading;
using System.Windows.Forms;
using TM_Parameter;
using TM_UI;

namespace TM_Matching
{
    class Matching
    {
        public void Template_Single(Mat src, Mat temp, out Mat gray_result, out Mat tm_result, out Mat result, out int rank_Single, out double similarity_Single, out OpenCvSharp.Point maxPoint_Single)
        {
            // 변수 초기화
            Mat match = src;
            Mat template = temp;
            Mat tm = new Mat();
            gray_result = new Mat();
            tm_result = new Mat();
            result = new Mat();
            rank_Single= 1;
            similarity_Single = 0;
            maxPoint_Single=new Point();
            OpenCvSharp.Point minloc, maxloc;
            double minval, maxval;

            // 템플릿 크기 확인
            if (match.Width >= template.Width && match.Height >= template.Height)
            {
                tm = new Mat(match.Width - template.Width + 1, match.Height - template.Height + 1, MatType.CV_32FC1, 1);
            }
            else
            {
                MessageBox.Show("템플릿은 이미지보다 크기가 작아야 합니다.", "Error");
                gray_result = null;
                tm_result = null;
                result = null;
                return;
            }

            // 템플릿 매칭 실행
            Cv2.MatchTemplate(match, template, tm, TemplateMatchModes.CCoeffNormed);
            Cv2.MinMaxLoc(tm, out minval, out maxval, out minloc, out maxloc);

            // 결과 이미지 반환
            Cv2.CvtColor(match, gray_result, ColorConversionCodes.BGRA2GRAY);

            Cv2.Normalize(tm, tm_result, 0, 255, NormTypes.MinMax);
            tm_result.ConvertTo(tm_result, MatType.CV_8UC1);

            Cv2.CvtColor(match, result, ColorConversionCodes.BGRA2BGR);

            // Threshold 확인 및 사각형 생성, listView 데이터 반환
            if (maxval >= Form_Parameter.single_Thr)
            {
                Cv2.Rectangle(result, new Rect(maxloc.X, maxloc.Y, template.Width, template.Height), new Scalar(0, 0, 255), 3);
                similarity_Single = maxval;
                maxPoint_Single = maxloc;
            }

            else
            {
                result = src;
            }
        }
        public void Template_Multiple(Mat src, Mat temp, out Mat gray_result, out Mat tm_result, out Mat result, out (int, double, OpenCvSharp.Point)[] tuple_Multiple_arr)
        {
            // 변수 초기화
            Mat match = src;
            Mat source_image = src.Clone();
            Mat template = temp;
            Mat tm = new Mat();
            Mat tm_src = new Mat();
            tuple_Multiple_arr = new (int, double, OpenCvSharp.Point)[Form_Parameter.multiple_Count];
            OpenCvSharp.Point minloc, maxloc;
            double minval, maxval;
            gray_result = new Mat();
            tm_result = new Mat();
            result = new Mat();

            if (match.Width >= template.Width && match.Height >= template.Height)
            {
                tm = new Mat(match.Width - template.Width + 1, match.Height - template.Height + 1, MatType.CV_32FC1, 1);
            }
            else
            {
                MessageBox.Show("템플릿은 이미지보다 크기가 작아야 합니다.", "Error");
                gray_result = null;
                tm_result = null;
                result = null;
                return;
            }

            // 템플릿 매칭 실행
            Cv2.CvtColor(match, result, ColorConversionCodes.BGRA2BGR);

            for (int i = 1; i <= Form_Parameter.multiple_Count; i++)
            {
                Cv2.MatchTemplate(match, template, tm, TemplateMatchModes.CCoeffNormed);
                if (i == 1)
                {
                    tm_src = tm.Clone();
                }
                Cv2.MinMaxLoc(tm, out minval, out maxval, out minloc, out maxloc);
                Cv2.Rectangle(result, new Rect(maxloc.X, maxloc.Y, template.Width, template.Height), new Scalar(0, 0, 255), 3);
                Cv2.PutText(result, $"{i}", new Point (maxloc.X - 5, maxloc.Y - 10), HersheyFonts.HersheySimplex, 1, new Scalar(0, 0, 255), 3, LineTypes.AntiAlias);
                Cv2.Rectangle(match, new Rect(maxloc.X, maxloc.Y, template.Width, template.Height), new Scalar(255, 255, 255), -1);
                tuple_Multiple_arr[i - 1] = (i, maxval, maxloc);
            }

            // 결과 이미지 반환
            Cv2.CvtColor(source_image, gray_result, ColorConversionCodes.BGRA2GRAY);

            Cv2.Normalize(tm_src, tm_result, 0, 255, NormTypes.MinMax);
            tm_result.ConvertTo(tm_result, MatType.CV_8UC1);
        }
    }
}
