// BibliotekaCpp.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "library.h"
#include <stdlib.h>

void __stdcall cEncodeText(char* text, char* text2, int startIndex, int endIndex)
{	
	int j = 0;
	for (int i = startIndex; i < endIndex; i++)
	{
		if ((text[i] >= 65) && (text[i] <= 90))
		{
			if (text[i] > 77)
			{
				text2[j] = text[i] - 13;
			}
			else
			{
				text2[j] = text[i] + 13;
			}
		}
		else if ((text[i] >= 97) && (text[i] <= 122))
		{
			if (text[i] > 109)
			{
				text2[j] = text[i] - 13;
			}
			else
			{
				text2[j] = text[i] + 13;
			}			
		}
		else
		{
			text2[j] = text[i];
		}
		j++;	
	}
}


