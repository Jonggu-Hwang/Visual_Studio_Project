#pragma once

#ifdef CREATEDLL_EXPORTS
#define DECLSPEC __declspec(dllexport)
#else
#define DECLSPEC __declspec(dllimport)
#endif

extern "C" DECLSPEC double Sum(double a, double b);
extern "C" DECLSPEC double Substract(double a, double b);
extern "C" DECLSPEC double Multiply(double a, double b);
extern "C" DECLSPEC double Divide(double a, double b);