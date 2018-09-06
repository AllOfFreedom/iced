﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_NASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Nasm {
	public sealed class NasmFormatterTest16_NoMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos16_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos16_000.AllInfos_Length] {
			"push es",
			"o32 push es",
			"pop es",
			"o32 pop es",
			"push cs",
			"o32 push cs",
			"push ss",
			"o32 push ss",
			"pop ss",
			"o32 pop ss",
			"push ds",
			"o32 push ds",
			"pop ds",
			"o32 pop ds",
			"pusha",
			"pushad",
			"popa",
			"popad",
			"push dword 0x3412a55a",
			"o32 push byte 0xffffffa5",
			"jo 0x804c",
			"o32 jo 0x0000804d",
			"jno 0x804c",
			"o32 jno 0x0000804d",
			"jb 0x804c",
			"o32 jb 0x0000804d",
			"jae 0x804c",
			"o32 jae 0x0000804d",
			"je 0x804c",
			"o32 je 0x0000804d",
			"jne 0x804c",
			"o32 jne 0x0000804d",
			"jbe 0x804c",
			"o32 jbe 0x0000804d",
			"ja 0x804c",
			"o32 ja 0x0000804d",
			"js 0x804c",
			"o32 js 0x0000804d",
			"jns 0x804c",
			"o32 jns 0x0000804d",
			"jp 0x804c",
			"o32 jp 0x0000804d",
			"jnp 0x804c",
			"o32 jnp 0x0000804d",
			"jl 0x804c",
			"o32 jl 0x0000804d",
			"jge 0x804c",
			"o32 jge 0x0000804d",
			"jle 0x804c",
			"o32 jle 0x0000804d",
			"jg 0x804c",
			"o32 jg 0x0000804d",
			"pop esi",
			"pop dword [bx+si]",
			"call 0x7856:0x3412",
			"call 0xbc9a:0x78563412",
			"pushfd",
			"popfd",
			"ret 0xa55a",
			"retd 0xa55a",
			"ret",
			"retd",
			"les bx,[bx+si]",
			"les ebx,[bx+si]",
			"lds bx,[bx+si]",
			"lds ebx,[bx+si]",
			"o32 enter 0xa55a,0xa6",
			"o32 leave",
			"loopne 0x804c",
			"o32 loopne 0x0000804d",
			"loopne 0x804d,ecx",
			"o32 loopne 0x0000804e,ecx",
			"loope 0x804c",
			"o32 loope 0x0000804d",
			"loope 0x804d,ecx",
			"o32 loope 0x0000804e,ecx",
			"loop 0x804c",
			"o32 loop 0x0000804d",
			"loop 0x804d,ecx",
			"o32 loop 0x0000804e,ecx",
			"jcxz 0x804c",
			"o32 jcxz 0x0000804d",
			"jecxz 0x804d",
			"o32 jecxz 0x0000804e",
			"call 0x254d",
			"call 0xa55ab408",
			"jmp 0x254d",
			"jmp 0xa55ab408",
			"jmp 0x7856:0x3412",
			"jmp 0xbcea:0x78563412",
			"jmp 0x804c",
			"o32 jmp 0x0000804d",
			"call cx",
			"call [bx+si]",
			"call ecx",
			"call [bx+si]",
			"jmp dx",
			"jmp [bx+si]",
			"jmp edx",
			"jmp [bx+si]",
			"push esi",
			"push dword [bx+si]",
			"bndmov bnd1,bnd2",
			"bndmov bnd1,[bx+si]",
			"bndcl bnd1,edx",
			"bndcl bnd1,[bx+si]",
			"bndcu bnd1,edx",
			"bndcu bnd1,[bx+si]",
			"bndmov bnd2,bnd1",
			"bndmov [bx+si],bnd1",
			"bndmk bnd1,[bx+si]",
			"bndcn bnd1,edx",
			"bndcn bnd1,[bx+si]",
			"vmread esi,ecx",
			"vmread [bx+si],ebx",
			"vmwrite ecx,esi",
			"vmwrite ebx,[bx+si]",
			"jo 0x254e",
			"jo 0x34132551",
			"jno 0x254e",
			"jno 0x34132551",
			"jb 0x254e",
			"jb 0x34132551",
			"jae 0x254e",
			"jae 0x34132551",
			"je 0x254e",
			"je 0x34132551",
			"jne 0x254e",
			"jne 0x34132551",
			"jbe 0x254e",
			"jbe 0x34132551",
			"ja 0x254e",
			"ja 0x34132551",
			"js 0x254e",
			"js 0x34132551",
			"jns 0x254e",
			"jns 0x34132551",
			"jp 0x254e",
			"jp 0x34132551",
			"jnp 0x254e",
			"jnp 0x34132551",
			"jl 0x254e",
			"jl 0x34132551",
			"jge 0x254e",
			"jge 0x34132551",
			"jle 0x254e",
			"jle 0x34132551",
			"jg 0x254e",
			"jg 0x34132551",
			"o32 push fs",
			"o32 pop fs",
			"o32 push gs",
			"o32 pop gs",
			"invept edx,[bx+si]",
			"invvpid edx,[bx+si]",
			"invpcid edx,[bx+si]",
			"push 0xa55a",
			"push byte 0xffa5",
			"a32 insb",
			"insb",
			"a32 insw",
			"insw",
			"a32 insd",
			"insd",
			"a32 outsb",
			"outsb",
			"a32 outsw",
			"outsw",
			"a32 outsd",
			"outsd",
			"mov fs,si",
			"mov ds,[bx+si]",
			"mov fs,esi",
			"o32 mov ds,[bx+si]",
			"pop si",
			"pop word [bx+si]",
			"nop",
			"xchg eax,eax",
			"pushf",
			"popf",
			"mov al,[0xf0de]",
			"mov al,[dword 0x78563412]",
			"mov ax,[0xf0de]",
			"mov ax,[dword 0x78563412]",
			"mov eax,[0xf0de]",
			"mov eax,[dword 0x78563412]",
			"mov [0xf0de],al",
			"mov [dword 0x78563412],al",
			"mov [0xf0de],ax",
			"mov [dword 0x78563412],ax",
			"mov [0xf0de],eax",
			"mov [dword 0x78563412],eax",
			"a32 movsb",
			"movsb",
			"a32 movsw",
			"movsw",
			"a32 movsd",
			"movsd",
			"a32 cmpsb",
			"cmpsb",
			"a32 cmpsw",
			"cmpsw",
			"a32 cmpsd",
			"cmpsd",
			"a32 stosb",
			"stosb",
			"a32 stosw",
			"stosw",
			"a32 stosd",
			"stosd",
			"a32 lodsb",
			"lodsb",
			"a32 lodsw",
			"lodsw",
			"a32 lodsd",
			"lodsd",
			"a32 scasb",
			"scasb",
			"a32 scasw",
			"scasw",
			"a32 scasd",
			"scasd",
			"xbegin 0x254e",
			"xbegin 0x2551",
			"enter 0xa55a,0xa6",
			"leave",
			"retf 0xa55a",
			"retfd 0xa55a",
			"retf",
			"retfd",
			"iret",
			"iretd",
			"rol cl,cl",
			"rol byte [bx+si],cl",
			"ror dl,cl",
			"ror byte [bx+si],cl",
			"rcl bl,cl",
			"rcl byte [bx+si],cl",
			"rcr ah,cl",
			"rcr byte [bx+si],cl",
			"shl ch,cl",
			"shl byte [bx+si],cl",
			"shr dh,cl",
			"shr byte [bx+si],cl",
			"sar al,cl",
			"sar byte [bx+si],cl",
			"rol cx,cl",
			"rol word [bx+si],cl",
			"rol ecx,cl",
			"rol dword [bx+si],cl",
			"ror dx,cl",
			"ror word [bx+si],cl",
			"ror edx,cl",
			"ror dword [bx+si],cl",
			"rcl bx,cl",
			"rcl word [bx+si],cl",
			"rcl ebx,cl",
			"rcl dword [bx+si],cl",
			"rcr sp,cl",
			"rcr word [bx+si],cl",
			"rcr esp,cl",
			"rcr dword [bx+si],cl",
			"shl bp,cl",
			"shl word [bx+si],cl",
			"shl ebp,cl",
			"shl dword [bx+si],cl",
			"shr si,cl",
			"shr word [bx+si],cl",
			"shr esi,cl",
			"shr dword [bx+si],cl",
			"sar ax,cl",
			"sar word [bx+si],cl",
			"sar eax,cl",
			"sar dword [bx+si],cl",
			"fldcw [bx+si]",
			"fnstcw [bx+si]",
			"fnstsw [bx+si]",
			"call far [bx+si]",
			"call dword far [bx+si]",
			"jmp far [bx+si]",
			"jmp dword far [bx+si]",
			"push si",
			"push word [bx+si]",
			"sgdt [bx+si]",
			"o32 sgdt [bx+si]",
			"sidt [bx+si]",
			"o32 sidt [bx+si]",
			"lgdt [bx+si]",
			"o32 lgdt [bx+si]",
			"lidt [bx+si]",
			"o32 lidt [bx+si]",
			"lar cx,si",
			"lar bx,[bx+si]",
			"lar ecx,esi",
			"lar ebx,[bx+si]",
			"lsl cx,si",
			"lsl bx,[bx+si]",
			"lsl ecx,esi",
			"lsl ebx,[bx+si]",
			"bndldx bnd1,[bx+si]",
			"bndstx [bx+si],bnd1",
			"kmovw k2,k3",
			"kmovw k1,[bx+si]",
			"kmovb k2,k3",
			"kmovb k1,[bx+si]",
			"kmovd k2,k3",
			"kmovd k1,[bx+si]",
			"kmovw [bx+si],k1",
			"kmovb [bx+si],k1",
			"kmovd [bx+si],k1",
			"kmovw k2,ebx",
			"kmovb k2,ebx",
			"kmovd k2,ebx",
			"kmovw edx,k3",
			"kmovb edx,k3",
			"kmovd edx,k3",
			"kortestw k2,k3",
			"kortestq k2,k3",
			"kortestb k2,k3",
			"kortestd k2,k3",
			"ktestw k2,k3",
			"ktestq k2,k3",
			"ktestb k2,k3",
			"ktestd k2,k3",
			"push fs",
			"pop fs",
			"shld si,cx,cl",
			"shld [bx+si],bx,cl",
			"shld esi,ecx,cl",
			"shld [bx+si],ebx,cl",
			"push gs",
			"pop gs",
			"shrd si,cx,cl",
			"shrd [bx+si],bx,cl",
			"shrd esi,ecx,cl",
			"shrd [bx+si],ebx,cl",
			"lss bx,[bx+si]",
			"lss ebx,[bx+si]",
			"lfs bx,[bx+si]",
			"lfs ebx,[bx+si]",
			"lgs bx,[bx+si]",
			"lgs ebx,[bx+si]",
			"movzx cx,dh",
			"movzx bx,byte [bx+si]",
			"movzx ecx,dh",
			"movzx ebx,byte [bx+si]",
			"movzx cx,si",
			"movzx bx,word [bx+si]",
			"movzx ecx,si",
			"movzx ebx,word [bx+si]",
			"movsx cx,dh",
			"movsx bx,byte [bx+si]",
			"movsx ecx,dh",
			"movsx ebx,byte [bx+si]",
			"movsx cx,si",
			"movsx bx,word [bx+si]",
			"movsx ecx,si",
			"movsx ebx,word [bx+si]",
			"cmpxchg8b [bx+si]",
			"crc32 ecx,dh",
			"crc32 ebx,byte [bx+si]",
			"crc32 ecx,esi",
			"crc32 ebx,dword [bx+si]",
			"a32 maskmovq mm2,mm3",
			"maskmovq mm2,mm3",
			"a32 maskmovdqu xmm2,xmm3",
			"maskmovdqu xmm2,xmm3",
			"a32 vmaskmovdqu xmm2,xmm3",
			"vmaskmovdqu xmm2,xmm3",
			"fs outsb",
			"fs outsw",
			"fs outsd",
			"fs movsb",
			"fs movsw",
			"fs movsd",
			"fs cmpsb",
			"fs cmpsw",
			"fs cmpsd",
			"fs lodsb",
			"fs lodsw",
			"fs lodsd",
			"a32 xlatb",
			"fs xlatb",
			"fs maskmovq mm2,mm3",
			"fs maskmovdqu xmm2,xmm3",
			"fs vmaskmovdqu xmm2,xmm3",
			"xlatb",
			"aam",
			"aad",
			"aam 0xfa",
			"aad 0xfa",
			"fldenv [bx+si]",
			"o32 fldenv [bx+si]",
			"fnstenv [bx+si]",
			"o32 fnstenv [bx+si]",
			"frstor [bx+si]",
			"o32 frstor [bx+si]",
			"fnsave [bx+si]",
			"o32 fnsave [bx+si]",
			"monitor",
			"a32 monitor",
			"mwait",
			"mov al,[fs:0xf0de]",
			"mov al,[dword fs:0x78563412]",
			"mov ax,[fs:0xf0de]",
			"mov ax,[dword fs:0x78563412]",
			"mov eax,[fs:0xf0de]",
			"mov eax,[dword fs:0x78563412]",
			"mov [fs:0xf0de],al",
			"mov [dword fs:0x78563412],al",
			"mov [fs:0xf0de],ax",
			"mov [dword fs:0x78563412],ax",
			"mov [fs:0xf0de],eax",
			"mov [dword fs:0x78563412],eax",
			"mov cl,[bx+si]",
			"mov cl,[bx+di]",
			"mov cl,[bp+si]",
			"mov cl,[bp+di]",
			"mov cl,[si]",
			"mov cl,[di]",
			"mov cl,[0xedcc]",
			"mov cl,[0x1234]",
			"mov cl,[bx]",
			"mov cl,[bx+si-0x12]",
			"mov cl,[bx+di-0x12]",
			"mov cl,[bp+si-0x12]",
			"mov cl,[bp+di-0x12]",
			"mov cl,[si-0x12]",
			"mov cl,[di-0x12]",
			"mov cl,[bp-0x12]",
			"mov cl,[bx-0x12]",
			"mov cl,[bx+si+0x12]",
			"mov cl,[bx+di+0x12]",
			"mov cl,[bp+si+0x12]",
			"mov cl,[bp+di+0x12]",
			"mov cl,[si+0x12]",
			"mov cl,[di+0x12]",
			"mov cl,[bp+0x12]",
			"mov cl,[bx+0x12]",
			"mov cl,[bx+si-0x1234]",
			"mov cl,[bx+di-0x1234]",
			"mov cl,[bp+si-0x1234]",
			"mov cl,[bp+di-0x1234]",
			"mov cl,[si-0x1234]",
			"mov cl,[di-0x1234]",
			"mov cl,[bp-0x1234]",
			"mov cl,[bx-0x1234]",
			"mov cl,[bx+si+0x1234]",
			"mov cl,[bx+di+0x1234]",
			"mov cl,[bp+si+0x1234]",
			"mov cl,[bp+di+0x1234]",
			"mov cl,[si+0x1234]",
			"mov cl,[di+0x1234]",
			"mov cl,[bp+0x1234]",
			"mov cl,[bx+0x1234]",
			"mov cl,[fs:bx+si]",
			"mov cl,[fs:bx+di]",
			"mov cl,[fs:bp+si]",
			"mov cl,[fs:bp+di]",
			"mov cl,[fs:si]",
			"mov cl,[fs:di]",
			"mov cl,[fs:0xedcc]",
			"mov cl,[fs:0x1234]",
			"mov cl,[fs:bx]",
			"mov cl,[fs:bx+si-0x12]",
			"mov cl,[fs:bx+di-0x12]",
			"mov cl,[fs:bp+si-0x12]",
			"mov cl,[fs:bp+di-0x12]",
			"mov cl,[fs:si-0x12]",
			"mov cl,[fs:di-0x12]",
			"mov cl,[fs:bp-0x12]",
			"mov cl,[fs:bx-0x12]",
			"mov cl,[fs:bx+si+0x12]",
			"mov cl,[fs:bx+di+0x12]",
			"mov cl,[fs:bp+si+0x12]",
			"mov cl,[fs:bp+di+0x12]",
			"mov cl,[fs:si+0x12]",
			"mov cl,[fs:di+0x12]",
			"mov cl,[fs:bp+0x12]",
			"mov cl,[fs:bx+0x12]",
			"mov cl,[fs:bx+si-0x1234]",
			"mov cl,[fs:bx+di-0x1234]",
			"mov cl,[fs:bp+si-0x1234]",
			"mov cl,[fs:bp+di-0x1234]",
			"mov cl,[fs:si-0x1234]",
			"mov cl,[fs:di-0x1234]",
			"mov cl,[fs:bp-0x1234]",
			"mov cl,[fs:bx-0x1234]",
			"mov cl,[fs:bx+si+0x1234]",
			"mov cl,[fs:bx+di+0x1234]",
			"mov cl,[fs:bp+si+0x1234]",
			"mov cl,[fs:bp+di+0x1234]",
			"mov cl,[fs:si+0x1234]",
			"mov cl,[fs:di+0x1234]",
			"mov cl,[fs:bp+0x1234]",
			"mov cl,[fs:bx+0x1234]",
		};
	}
}
#endif
