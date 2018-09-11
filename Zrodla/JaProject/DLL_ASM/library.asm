.code
	encodeText proc
				;push using registers to the stack
				push rcx
				push rdi
				push r12
				;initialise rdi as text jumper and copy amount of characters to r12
				mov rdi, 0			
				mov r12, rdx
				;copy character to rax
		_loop:	mov rax, [rcx+rdi]	
				;check if to character should be added 13, deducted 13 or character should be just copied			
				cmp al, 90
				ja _check109
				jbe _check65
	_check109:	cmp al, 109
				ja _check122
				jbe _check97
	_check122:	cmp al, 122
				ja _copy
				jbe _sub
	_check97:	cmp al, 97
				jae _add
				jb	_copy
	_check65:	cmp al, 65
				jae _check77
				jb _copy
	_check77:	cmp al, 77
				ja _sub
				jbe _add				
				;sub from letter 13 and save it in text
		_sub:	sub al, 13
				mov [rcx+rdi], al
				;decrease amount of characters
				dec r12
				jmp _checkend
				;add to letter 13 and save it in text
		_add:	add al, 13
				mov [rcx+rdi], al
				;decrease amount of characters
				dec r12
				jmp _checkend
				;copy character to text
		_copy:	mov [rcx+rdi], al
				;decrease amount of characters
				dec r12
				jmp _checkend
				;check if amount of characters is different from zero
	_checkend:	cmp r12, 0
				je _end
				;move text jumper to the next character
				add rdi, 2
				jmp _loop
				;pop using registers from the stack and return encoded text
		_end:	pop r12
				pop rdi
				mov rax, rcx
				pop rcx
				ret
	encodeText endp


.data
characterz db 91, 0, 91, 0, 91, 0, 91, 0, 91, 0, 91, 0, 91, 0, 91, 0
charactersmallz db 123, 0, 123, 0, 123, 0, 123, 0, 123, 0, 123, 0, 123, 0, 123, 0
charactera db 65, 0, 65, 0, 65, 0, 65, 0, 65, 0, 65, 0, 65, 0, 65, 0
charactersmalla db 97, 0, 97, 0, 97, 0, 97, 0, 97, 0, 97, 0, 97, 0, 97, 0
characterm db 78, 0, 78, 0, 78, 0, 78, 0, 78, 0, 78, 0, 78, 0, 78, 0
charactersmallm db 110, 0, 110, 0, 110, 0, 110, 0, 110, 0, 110, 0, 110, 0, 110, 0
subnumber db 255, 0, 255, 0, 255, 0, 255, 0, 255, 0, 255, 0, 255, 0, 255, 0
addnumber dw 510, 510, 510, 510, 510, 510, 510, 510
number db 13, 0, 13, 0, 13, 0, 13, 0, 13, 0, 13, 0, 13, 0, 13, 0
negativenumber dw -13, -13, -13, -13, -13, -13, -13, -13
.code
	vectorialEncodeText proc
				;push using registers to the stack
				push rcx
				push rdi
				push r13
				;initialise rdi as text jumper and copy amount of characters to r13
				mov r13, rdx
				mov rdi, 0
				;check if text is not empty
				cmp r13, 0
				je _end			
				;clear xmm registers
	_loop:		xorps xmm1, xmm1
				xorps xmm2, xmm2
				xorps xmm3, xmm3
				xorps xmm4, xmm4
				xorps xmm5, xmm5
				xorps xmm6, xmm6
				;load 8 characters to xmm7
				movups xmm7, [rcx+rdi]
				;load test characters to registers xmm1-xmm6
				paddb xmm1, characterz
				paddb xmm2, charactersmallz
				paddb xmm3, charactera
				paddb xmm4, charactersmalla
				paddb xmm5, characterm
				paddb xmm6, charactersmallm
				;check if character in xmm7 is greater than character in xmm1-xmm6
				PCMPGTB xmm1, xmm7 
				PCMPGTB xmm2, xmm7 
				PCMPGTB xmm3, xmm7 
				PCMPGTB xmm4, xmm7 
				PCMPGTB xmm5, xmm7 
				PCMPGTB xmm6, xmm7 
				;check small letter, if it is - value is 510 or 255
				paddsw xmm2, xmm4
				paddsw xmm2, xmm6
				;clear xmm4 and xmm6				
				xorps xmm4, xmm4
				xorps xmm6, xmm6
				;load to xmm4 510, to xmm6 255 and compare it with small letters test
				paddsw xmm4, addnumber
				paddsb xmm6, subnumber
				pcmpeqb xmm4, xmm2
				pcmpeqb xmm6, xmm2
				;load +13 to xmm4 values if results of comparsion  equal -1
				xorps xmm2, xmm2
				paddb xmm2, number
				pand xmm4, xmm2
				;load -13 to xmm4 values if results of comparsion  equal -1
				xorps xmm2, xmm2
				paddw xmm2, negativenumber
				pand xmm6, xmm2
				;store operation on small letters in xmm4
				paddsw xmm4, xmm6
				;check capital letter, if it is - value is 510 or 255
				paddsw xmm1, xmm3
				paddsw xmm1, xmm5
				;clear xmm3 and xmm5
				xorps xmm3, xmm3
				xorps xmm5, xmm5
				;load to xmm3 510, to xmm5 255 and compare it with capital letters test
				paddsw xmm3, addnumber
				paddsb xmm5, subnumber
				pcmpeqb xmm3, xmm1
				pcmpeqw xmm5, xmm1
				;load +13 to xmm3 values if results of comparsion  equal -1
				xorps xmm1, xmm1
				paddb xmm1, number
				pand xmm3, xmm1
				;load -13 to xmm3 values if results of comparsion  equal -1
				xorps xmm1, xmm1
				paddw xmm1, negativenumber
				pand xmm5, xmm1
				;store operation on capital letters in xmm3
				paddsw xmm3, xmm5
				;sum operations on capital and small letters in xmm3
				paddsw xmm3, xmm4		
				;add xmm3 to xmm7, copy it to text array and move to the next 8 characters
				paddsw xmm7, xmm3		
				movups [rcx+rdi], xmm7	
				add rdi, 16				
				;check if text has still any characters
				cmp r13, 8
				jbe _end
				;decrease amount of characters and jump to begin of loop
				sub r13, 8
				jmp _loop
				;get values of using register from the stack and return encoded text
	_end:		pop r13
				pop rdi
				mov rax, rcx
				pop rcx							
				ret
	vectorialEncodeText endp

END