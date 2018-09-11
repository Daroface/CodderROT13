#pragma once  

#ifndef MATH_HPP
#define MATH_HPP

extern "C"
{
	__declspec(dllexport) void __stdcall cEncodeText(char* text, char* text2, int startIndex, int endIndex);
}

#endif