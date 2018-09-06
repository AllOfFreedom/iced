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
	public sealed class NasmFormatterTest64_ForceMemSize_003 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_003.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_003.AllInfos_Length] {
			"vmovdqa64 zmm3,zmm2",
			"vmovdqa64 zword [rax+0x40],zmm2",
			"movdqu xmm5,xmm1",
			"movdqu oword [rax],xmm1",
			"vmovdqu xmm5,xmm1",
			"vmovdqu oword [rax],xmm2",
			"vmovdqu ymm5,ymm1",
			"vmovdqu yword [rax],ymm2",
			"vmovdqu32 xmm3,xmm2",
			"vmovdqu32 oword [rax+0x10],xmm2",
			"vmovdqu32 ymm3,ymm2",
			"vmovdqu32 yword [rax+0x20],ymm2",
			"vmovdqu32 zmm3,zmm2",
			"vmovdqu32 zword [rax+0x40],zmm2",
			"vmovdqu64 xmm3,xmm2",
			"vmovdqu64 oword [rax+0x10],xmm2",
			"vmovdqu64 ymm3,ymm2",
			"vmovdqu64 yword [rax+0x20],ymm2",
			"vmovdqu64 zmm3,zmm2",
			"vmovdqu64 zword [rax+0x40],zmm2",
			"vmovdqu8 xmm3,xmm2",
			"vmovdqu8 oword [rax+0x10],xmm2",
			"vmovdqu8 ymm3,ymm2",
			"vmovdqu8 yword [rax+0x20],ymm2",
			"vmovdqu8 zmm3,zmm2",
			"vmovdqu8 zword [rax+0x40],zmm2",
			"vmovdqu16 xmm3,xmm2",
			"vmovdqu16 oword [rax+0x10],xmm2",
			"vmovdqu16 ymm3,ymm2",
			"vmovdqu16 yword [rax+0x20],ymm2",
			"vmovdqu16 zmm3,zmm2",
			"vmovdqu16 zword [rax+0x40],zmm2",
			"jo near 0x800000003412a550",
			"jno near 0x800000003412a550",
			"jb near 0x800000003412a550",
			"jae near 0x800000003412a550",
			"je near 0x800000003412a550",
			"jne near 0x800000003412a550",
			"jbe near 0x800000003412a550",
			"ja near 0x800000003412a550",
			"js near 0x800000003412a550",
			"jns near 0x800000003412a550",
			"jp near 0x800000003412a550",
			"jnp near 0x800000003412a550",
			"jl near 0x800000003412a550",
			"jge near 0x800000003412a550",
			"jle near 0x800000003412a550",
			"jg near 0x800000003412a550",
			"seto al",
			"setno al",
			"setb al",
			"setae al",
			"sete al",
			"setne al",
			"setbe al",
			"seta al",
			"sets al",
			"setns al",
			"setp al",
			"setnp al",
			"setl al",
			"setge al",
			"setle al",
			"setg al",
			"kmovw k2,k3",
			"kmovw k1,word [rax]",
			"kmovq k2,k3",
			"kmovq k1,qword [rax]",
			"kmovb k2,k3",
			"kmovb k1,byte [rax]",
			"kmovd k2,k3",
			"kmovd k1,dword [rax]",
			"kmovw word [rax],k1",
			"kmovq qword [rax],k1",
			"kmovb byte [rax],k1",
			"kmovd dword [rax],k1",
			"kmovw k2,ebx",
			"kmovb k2,ebx",
			"kmovq k2,rbx",
			"kmovd k2,ebx",
			"kmovw edx,k3",
			"kmovb edx,k3",
			"kmovq rdx,k3",
			"kmovd edx,k3",
			"kortestw k2,k3",
			"kortestq k2,k3",
			"kortestb k2,k3",
			"kortestd k2,k3",
			"ktestw k2,k3",
			"ktestq k2,k3",
			"ktestb k2,k3",
			"ktestd k2,k3",
			"o16 push fs",
			"push fs",
			"o16 pop fs",
			"pop fs",
			"cpuid",
			"bt si,cx",
			"bt word [rax],bx",
			"bt esi,ecx",
			"bt dword [rax],ebx",
			"bt rsi,rcx",
			"bt qword [rax],rbx",
			"shld si,cx,0x5a",
			"shld word [rax],bx,0x5a",
			"shld esi,ecx,0x5a",
			"shld dword [rax],ebx,0x5a",
			"shld rsi,rcx,0x5a",
			"shld qword [rax],rbx,0x5a",
			"shld si,cx,cl",
			"shld word [rax],bx,cl",
			"shld esi,ecx,cl",
			"shld dword [rax],ebx,cl",
			"shld rsi,rcx,cl",
			"shld qword [rax],rbx,cl",
			"o16 push gs",
			"push gs",
			"o16 pop gs",
			"pop gs",
			"rsm",
			"bts si,cx",
			"bts word [rax],bx",
			"bts esi,ecx",
			"bts dword [rax],ebx",
			"bts rsi,rcx",
			"bts qword [rax],rbx",
			"shrd si,cx,0x5a",
			"shrd word [rax],bx,0x5a",
			"shrd esi,ecx,0x5a",
			"shrd dword [rax],ebx,0x5a",
			"shrd rsi,rcx,0x5a",
			"shrd qword [rax],rbx,0x5a",
			"shrd si,cx,cl",
			"shrd word [rax],bx,cl",
			"shrd esi,ecx,cl",
			"shrd dword [rax],ebx,cl",
			"shrd rsi,rcx,cl",
			"shrd qword [rax],rbx,cl",
			"fxsave [rax]",
			"fxsave64 [rax]",
			"rdfsbase ebp",
			"rdfsbase rbp",
			"fxrstor [rax]",
			"fxrstor64 [rax]",
			"rdgsbase ebp",
			"rdgsbase rbp",
			"ldmxcsr dword [rax]",
			"wrfsbase ebp",
			"wrfsbase rbp",
			"vldmxcsr dword [rax]",
			"stmxcsr dword [rax]",
			"wrgsbase ebp",
			"wrgsbase rbp",
			"vstmxcsr dword [rax]",
			"xsave [rax]",
			"xsave64 [rax]",
			"ptwrite ebp",
			"ptwrite dword [rax]",
			"ptwrite rbp",
			"ptwrite qword [rax]",
			"xrstor [rax]",
			"xrstor64 [rax]",
			"xsaveopt [rax]",
			"xsaveopt64 [rax]",
			"clwb [rax]",
			"clflush [rax]",
			"clflushopt [rax]",
			"lfence",
			"mfence",
			"sfence",
			"imul cx,si",
			"imul bx,word [rax]",
			"imul ecx,esi",
			"imul ebx,dword [rax]",
			"imul rcx,rsi",
			"imul rbx,qword [rax]",
			"cmpxchg dh,cl",
			"cmpxchg byte [rax],bh",
			"cmpxchg si,cx",
			"cmpxchg word [rax],bx",
			"cmpxchg esi,ecx",
			"cmpxchg dword [rax],ebx",
			"cmpxchg rsi,rcx",
			"cmpxchg qword [rax],rbx",
			"lss bx,[rax]",
			"lss ebx,[rax]",
			"lss rbx,[rax]",
			"btr si,cx",
			"btr word [rax],bx",
			"btr esi,ecx",
			"btr dword [rax],ebx",
			"btr rsi,rcx",
			"btr qword [rax],rbx",
			"lfs bx,[rax]",
			"lfs ebx,[rax]",
			"lfs rbx,[rax]",
			"lgs bx,[rax]",
			"lgs ebx,[rax]",
			"lgs rbx,[rax]",
			"movzx cx,dh",
			"movzx bx,byte [rax]",
			"movzx ecx,dh",
			"movzx ebx,byte [rax]",
			"movzx rcx,sil",
			"movzx rbx,byte [rax]",
			"movzx cx,si",
			"movzx bx,word [rax]",
			"movzx ecx,si",
			"movzx ebx,word [rax]",
			"movzx rcx,si",
			"movzx rbx,word [rax]",
			"popcnt cx,si",
			"popcnt bx,word [rax]",
			"popcnt ecx,esi",
			"popcnt ebx,dword [rax]",
			"popcnt rcx,rsi",
			"popcnt rbx,qword [rax]",
			"ud1 cx,si",
			"ud1 bx,word [rax]",
			"ud1 ecx,esi",
			"ud1 ebx,dword [rax]",
			"ud1 rcx,rsi",
			"ud1 rbx,qword [rax]",
			"bt bp,0x5a",
			"bt word [rax],0x5a",
			"bt ebp,0x5a",
			"bt dword [rax],0x5a",
			"bt rbp,0x5a",
			"bt qword [rax],0x5a",
			"bts si,-0x5b",
			"bts word [rax],-0x5b",
			"bts esi,-0x5b",
			"bts dword [rax],-0x5b",
			"bts rsi,-0x5b",
			"bts qword [rax],-0x5b",
			"btr di,0x5a",
			"btr word [rax],0x5a",
			"btr edi,0x5a",
			"btr dword [rax],0x5a",
			"btr rdi,0x5a",
			"btr qword [rax],0x5a",
			"btc ax,-0x5b",
			"btc word [rax],-0x5b",
			"btc eax,-0x5b",
			"btc dword [rax],-0x5b",
			"btc r8,-0x5b",
			"btc qword [rax],-0x5b",
			"btc si,cx",
			"btc word [rax],bx",
			"btc esi,ecx",
			"btc dword [rax],ebx",
			"btc rsi,rcx",
			"btc qword [rax],rbx",
			"bsf cx,si",
			"bsf bx,word [rax]",
			"bsf ecx,esi",
			"bsf ebx,dword [rax]",
			"bsf rcx,rsi",
			"bsf rbx,qword [rax]",
			"bsr cx,si",
			"bsr bx,word [rax]",
			"bsr ecx,esi",
			"bsr ebx,dword [rax]",
			"bsr rcx,rsi",
			"bsr rbx,qword [rax]",
			"movsx cx,dh",
			"movsx bx,byte [rax]",
			"movsx ecx,dh",
			"movsx ebx,byte [rax]",
			"movsx rcx,sil",
			"movsx rbx,byte [rax]",
			"movsx cx,si",
			"movsx bx,word [rax]",
			"movsx ecx,si",
			"movsx ebx,word [rax]",
			"movsx rcx,si",
			"movsx rbx,word [rax]",
			"tzcnt cx,si",
			"tzcnt bx,word [rax]",
			"tzcnt ecx,esi",
			"tzcnt ebx,dword [rax]",
			"tzcnt rcx,rsi",
			"tzcnt rbx,qword [rax]",
			"lzcnt cx,si",
			"lzcnt bx,word [rax]",
			"lzcnt ecx,esi",
			"lzcnt ebx,dword [rax]",
			"lzcnt rcx,rsi",
			"lzcnt rbx,qword [rax]",
			"xadd dh,cl",
			"xadd byte [rax],bh",
			"xadd si,cx",
			"xadd word [rax],bx",
			"xadd esi,ecx",
			"xadd dword [rax],ebx",
			"xadd rsi,rcx",
			"xadd qword [rax],rbx",
			"cmpps xmm1,xmm5,-0x5b",
			"cmpps xmm1,[rax],-0x5b",
			"vcmpps xmm2,xmm6,xmm3,-0x5b",
			"vcmpps xmm2,xmm6,oword [rax],-0x5b",
			"vcmpps ymm2,ymm6,ymm3,-0x5b",
			"vcmpps ymm2,ymm6,yword [rax],-0x5b",
			"vcmpps k2{k3},xmm6,xmm3,-0x5b",
			"vcmpps k2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vcmpps k2{k5},xmm6,dword [rax+4]{1to4},-0x5b",
			"vcmpps k2{k3},ymm6,ymm3,-0x5b",
			"vcmpps k2{k3},ymm6,yword [rax+0x20],-0x5b",
			"vcmpps k2{k5},ymm6,dword [rax+4]{1to8},-0x5b",
			"vcmpps k2{k3},zmm6,zmm3,{sae},-0x5b",
			"vcmpps k2{k3},zmm6,zword [rax+0x40],-0x5b",
			"vcmpps k2{k5},zmm6,dword [rax+4]{1to16},-0x5b",
			"cmppd xmm1,xmm5,-0x5b",
			"cmppd xmm1,oword [rax],-0x5b",
			"vcmppd xmm2,xmm6,xmm3,-0x5b",
			"vcmppd xmm2,xmm6,oword [rax],-0x5b",
			"vcmppd ymm2,ymm6,ymm3,-0x5b",
			"vcmppd ymm2,ymm6,yword [rax],-0x5b",
			"vcmppd k2{k3},xmm6,xmm3,-0x5b",
			"vcmppd k2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vcmppd k2{k5},xmm6,qword [rax+8]{1to2},-0x5b",
			"vcmppd k2{k3},ymm6,ymm3,-0x5b",
			"vcmppd k2{k3},ymm6,yword [rax+0x20],-0x5b",
			"vcmppd k2{k5},ymm6,qword [rax+8]{1to4},-0x5b",
			"vcmppd k2{k3},zmm6,zmm3,{sae},-0x5b",
			"vcmppd k2{k3},zmm6,zword [rax+0x40],-0x5b",
			"vcmppd k2{k5},zmm6,qword [rax+8]{1to8},-0x5b",
			"cmpss xmm1,xmm5,-0x5b",
			"cmpss xmm1,[rax],-0x5b",
			"vcmpss xmm2,xmm6,xmm3,-0x5b",
			"vcmpss xmm2,xmm6,qword [rax],-0x5b",
			"vcmpss k2{k3},xmm6,xmm3,-0x5b",
			"vcmpss k2{k3},xmm6,dword [rax+4],-0x5b",
			"cmpsd xmm1,xmm5,-0x5b",
			"cmpsd xmm1,oword [rax],-0x5b",
			"vcmpsd xmm2,xmm6,xmm3,-0x5b",
			"vcmpsd xmm2,xmm6,qword [rax],-0x5b",
			"vcmpsd k2{k3},xmm6,xmm3,-0x5b",
			"vcmpsd k2{k3},xmm6,qword [rax+8],-0x5b",
			"movnti dword [rax],ebx",
			"movnti qword [rax],rbx",
			"pinsrw mm1,ebp,-0x5b",
			"pinsrw mm1,word [rax],-0x5b",
			"pinsrw mm1,rbp,-0x5b",
			"pinsrw mm1,word [rax],-0x5b",
			"pinsrw xmm1,ebp,-0x5b",
			"pinsrw xmm1,word [rax],-0x5b",
			"pinsrw xmm1,rbp,-0x5b",
			"pinsrw xmm1,word [rax],-0x5b",
			"vpinsrw xmm2,xmm6,ebx,-0x5b",
			"vpinsrw xmm2,xmm6,word [rax],-0x5b",
			"vpinsrw xmm2,xmm6,rbx,-0x5b",
			"vpinsrw xmm2,xmm6,word [rax],-0x5b",
			"vpinsrw xmm2,xmm6,ebx,-0x5b",
			"vpinsrw xmm2,xmm6,word [rax+2],-0x5b",
			"vpinsrw xmm2,xmm6,rbx,-0x5b",
			"vpinsrw xmm2,xmm6,word [rax+2],-0x5b",
			"pextrw ecx,mm5,-0x5b",
			"pextrw rcx,mm5,-0x5b",
			"pextrw ecx,xmm5,-0x5b",
			"pextrw rcx,xmm5,-0x5b",
			"vpextrw edx,xmm3,-0x5b",
			"vpextrw rdx,xmm3,-0x5b",
			"vpextrw edx,xmm3,-0x5b",
			"vpextrw rdx,xmm3,-0x5b",
			"shufps xmm1,xmm5,-0x5b",
			"shufps xmm1,oword [rax],-0x5b",
			"vshufps xmm2,xmm6,xmm3,-0x5b",
			"vshufps xmm2,xmm6,oword [rax],-0x5b",
			"vshufps ymm2,ymm6,ymm3,-0x5b",
			"vshufps ymm2,ymm6,yword [rax],-0x5b",
			"vshufps xmm2{k3},xmm6,xmm3,-0x5b",
			"vshufps xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vshufps xmm2{k5}{z},xmm6,dword [rax+4]{1to4},-0x5b",
			"vshufps ymm2{k3},ymm6,ymm3,-0x5b",
			"vshufps ymm2{k3},ymm6,yword [rax+0x20],-0x5b",
			"vshufps ymm2{k5}{z},ymm6,dword [rax+4]{1to8},-0x5b",
			"vshufps zmm2{k3},zmm6,zmm3,-0x5b",
			"vshufps zmm2{k3},zmm6,zword [rax+0x40],-0x5b",
			"vshufps zmm2{k5}{z},zmm6,dword [rax+4]{1to16},-0x5b",
			"shufpd xmm1,xmm5,-0x5b",
			"shufpd xmm1,[rax],-0x5b",
			"vshufpd xmm2,xmm6,xmm3,-0x5b",
			"vshufpd xmm2,xmm6,oword [rax],-0x5b",
			"vshufpd ymm2,ymm6,ymm3,-0x5b",
			"vshufpd ymm2,ymm6,yword [rax],-0x5b",
			"vshufpd xmm2{k3}{z},xmm6,xmm3,-0x5b",
			"vshufpd xmm2{k3},xmm6,oword [rax+0x10],-0x5b",
			"vshufpd xmm2{k5}{z},xmm6,qword [rax+8]{1to2},-0x5b",
			"vshufpd ymm2{k3}{z},ymm6,ymm3,-0x5b",
			"vshufpd ymm2{k3},ymm6,yword [rax+0x20],-0x5b",
			"vshufpd ymm2{k5}{z},ymm6,qword [rax+8]{1to4},-0x5b",
			"vshufpd zmm2{k3}{z},zmm6,zmm3,-0x5b",
			"vshufpd zmm2{k3},zmm6,zword [rax+0x40],-0x5b",
			"vshufpd zmm2{k5}{z},zmm6,qword [rax+8]{1to8},-0x5b",
			"cmpxchg8b [rax]",
			"cmpxchg16b [rax]",
			"xrstors [rax]",
			"xrstors64 [rax]",
			"xsavec [rax]",
			"xsavec64 [rax]",
			"xsaves [rax]",
			"xsaves64 [rax]",
			"vmptrld [rax]",
			"vmclear [rax]",
			"vmxon [rax]",
			"rdrand dx",
			"rdrand edx",
			"rdrand rdx",
			"vmptrst [rax]",
			"rdseed dx",
			"rdseed edx",
			"rdseed rdx",
			"rdpid rdx",
			"bswap ax",
			"bswap r8w",
			"bswap eax",
			"bswap r8d",
			"bswap rax",
			"bswap r8",
			"bswap cx",
			"bswap r9w",
			"bswap ecx",
			"bswap r9d",
			"bswap rcx",
			"bswap r9",
			"bswap dx",
			"bswap r10w",
			"bswap edx",
			"bswap r10d",
			"bswap rdx",
			"bswap r10",
			"bswap bx",
			"bswap r11w",
			"bswap ebx",
			"bswap r11d",
			"bswap rbx",
			"bswap r11",
			"bswap sp",
			"bswap r12w",
			"bswap esp",
			"bswap r12d",
			"bswap rsp",
			"bswap r12",
			"bswap bp",
			"bswap r13w",
			"bswap ebp",
			"bswap r13d",
			"bswap rbp",
			"bswap r13",
			"bswap si",
			"bswap r14w",
			"bswap esi",
			"bswap r14d",
			"bswap rsi",
			"bswap r14",
			"bswap di",
			"bswap r15w",
			"bswap edi",
			"bswap r15d",
			"bswap rdi",
			"bswap r15",
			"addsubpd xmm1,xmm5",
			"addsubpd xmm1,oword [rax]",
			"vaddsubpd xmm2,xmm6,xmm3",
			"vaddsubpd xmm2,xmm6,oword [rax]",
			"vaddsubpd ymm2,ymm6,ymm3",
			"vaddsubpd ymm2,ymm6,yword [rax]",
			"addsubps xmm1,xmm5",
			"addsubps xmm1,oword [rax]",
			"vaddsubps xmm2,xmm6,xmm3",
			"vaddsubps xmm2,xmm6,oword [rax]",
			"vaddsubps ymm2,ymm6,ymm3",
			"vaddsubps ymm2,ymm6,yword [rax]",
			"psrlw mm1,mm5",
			"psrlw mm1,qword [rax]",
			"psrlw xmm1,xmm5",
			"psrlw xmm1,oword [rax]",
			"vpsrlw xmm2,xmm6,xmm3",
			"vpsrlw xmm2,xmm6,oword [rax]",
			"vpsrlw ymm2,ymm6,xmm3",
			"vpsrlw ymm2,ymm6,oword [rax]",
			"vpsrlw xmm2{k3},xmm6,xmm3",
			"vpsrlw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsrlw ymm2{k3},ymm6,xmm3",
			"vpsrlw ymm2{k3},ymm6,oword [rax+0x10]",
			"vpsrlw zmm2{k3},zmm6,xmm3",
			"vpsrlw zmm2{k3},zmm6,oword [rax+0x10]",
			"psrld mm1,mm5",
			"psrld mm1,qword [rax]",
			"psrld xmm1,xmm5",
			"psrld xmm1,oword [rax]",
			"vpsrld xmm2,xmm6,xmm3",
			"vpsrld xmm2,xmm6,oword [rax]",
			"vpsrld ymm2,ymm6,xmm3",
			"vpsrld ymm2,ymm6,oword [rax]",
			"vpsrld xmm2{k3},xmm6,xmm3",
			"vpsrld xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsrld ymm2{k3},ymm6,xmm3",
			"vpsrld ymm2{k3},ymm6,oword [rax+0x10]",
			"vpsrld zmm2{k3},zmm6,xmm3",
			"vpsrld zmm2{k3},zmm6,oword [rax+0x10]",
			"psrlq mm1,mm5",
			"psrlq mm1,qword [rax]",
			"psrlq xmm1,xmm5",
			"psrlq xmm1,oword [rax]",
			"vpsrlq xmm2,xmm6,xmm3",
			"vpsrlq xmm2,xmm6,oword [rax]",
			"vpsrlq ymm2,ymm6,xmm3",
			"vpsrlq ymm2,ymm6,oword [rax]",
			"vpsrlq xmm2{k3},xmm6,xmm3",
			"vpsrlq xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsrlq ymm2{k3},ymm6,xmm3",
			"vpsrlq ymm2{k3},ymm6,oword [rax+0x10]",
			"vpsrlq zmm2{k3},zmm6,xmm3",
			"vpsrlq zmm2{k3},zmm6,oword [rax+0x10]",
			"paddq mm1,mm5",
			"paddq mm1,qword [rax]",
			"paddq xmm1,xmm5",
			"paddq xmm1,oword [rax]",
			"vpaddq xmm2,xmm6,xmm3",
			"vpaddq xmm2,xmm6,oword [rax]",
			"vpaddq ymm2,ymm6,ymm3",
			"vpaddq ymm2,ymm6,yword [rax]",
			"vpaddq xmm2{k3}{z},xmm6,xmm3",
			"vpaddq xmm2{k3},xmm6,oword [rax+0x10]",
			"vpaddq xmm2{k5}{z},xmm6,qword [rax+8]{1to2}",
			"vpaddq ymm2{k3}{z},ymm6,ymm3",
			"vpaddq ymm2{k3},ymm6,yword [rax+0x20]",
			"vpaddq ymm2{k5}{z},ymm6,qword [rax+8]{1to4}",
			"vpaddq zmm2{k3}{z},zmm6,zmm3",
			"vpaddq zmm2{k3},zmm6,zword [rax+0x40]",
			"vpaddq zmm2{k5}{z},zmm6,qword [rax+8]{1to8}",
			"pmullw mm1,mm5",
			"pmullw mm1,qword [rax]",
			"pmullw xmm1,xmm5",
			"pmullw xmm1,oword [rax]",
			"vpmullw xmm2,xmm6,xmm3",
			"vpmullw xmm2,xmm6,oword [rax]",
			"vpmullw ymm2,ymm6,ymm3",
			"vpmullw ymm2,ymm6,yword [rax]",
			"vpmullw xmm2{k3},xmm6,xmm3",
			"vpmullw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpmullw ymm2{k3},ymm6,ymm3",
			"vpmullw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpmullw zmm2{k3},zmm6,zmm3",
			"vpmullw zmm2{k3},zmm6,zword [rax+0x40]",
			"movq xmm5,xmm1",
			"movq qword [rax],xmm1",
			"vmovq xmm5,xmm1",
			"vmovq qword [rax],xmm2",
			"vmovq xmm3,xmm2",
			"vmovq qword [rax+8],xmm2",
			"movq2dq xmm1,mm5",
			"movdq2q mm1,xmm5",
			"pmovmskb ecx,mm5",
			"pmovmskb rcx,mm5",
			"pmovmskb ecx,xmm5",
			"pmovmskb rcx,xmm5",
			"vpmovmskb ecx,xmm5",
			"vpmovmskb rcx,xmm5",
			"vpmovmskb ecx,ymm5",
			"vpmovmskb rcx,ymm5",
			"psubusb mm1,mm5",
			"psubusb mm1,qword [rax]",
			"psubusb xmm1,xmm5",
			"psubusb xmm1,oword [rax]",
			"vpsubusb xmm2,xmm6,xmm3",
			"vpsubusb xmm2,xmm6,oword [rax]",
			"vpsubusb ymm2,ymm6,ymm3",
			"vpsubusb ymm2,ymm6,yword [rax]",
			"vpsubusb xmm2{k3},xmm6,xmm3",
			"vpsubusb xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsubusb ymm2{k3},ymm6,ymm3",
			"vpsubusb ymm2{k3},ymm6,yword [rax+0x20]",
			"vpsubusb zmm2{k3},zmm6,zmm3",
			"vpsubusb zmm2{k3},zmm6,zword [rax+0x40]",
			"psubusw mm1,mm5",
			"psubusw mm1,qword [rax]",
			"psubusw xmm1,xmm5",
			"psubusw xmm1,oword [rax]",
			"vpsubusw xmm2,xmm6,xmm3",
			"vpsubusw xmm2,xmm6,oword [rax]",
			"vpsubusw ymm2,ymm6,ymm3",
			"vpsubusw ymm2,ymm6,yword [rax]",
			"vpsubusw xmm2{k3},xmm6,xmm3",
			"vpsubusw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsubusw ymm2{k3},ymm6,ymm3",
			"vpsubusw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpsubusw zmm2{k3},zmm6,zmm3",
			"vpsubusw zmm2{k3},zmm6,zword [rax+0x40]",
			"pminub mm1,mm5",
			"pminub mm1,qword [rax]",
			"pminub xmm1,xmm5",
			"pminub xmm1,oword [rax]",
			"vpminub xmm2,xmm6,xmm3",
			"vpminub xmm2,xmm6,oword [rax]",
			"vpminub ymm2,ymm6,ymm3",
			"vpminub ymm2,ymm6,yword [rax]",
			"vpminub xmm2{k3},xmm6,xmm3",
			"vpminub xmm2{k3},xmm6,oword [rax+0x10]",
			"vpminub ymm2{k3},ymm6,ymm3",
			"vpminub ymm2{k3},ymm6,yword [rax+0x20]",
			"vpminub zmm2{k3},zmm6,zmm3",
			"vpminub zmm2{k3},zmm6,zword [rax+0x40]",
			"pand mm1,mm5",
			"pand mm1,qword [rax]",
			"pand xmm1,xmm5",
			"pand xmm1,oword [rax]",
			"vpand xmm2,xmm6,xmm3",
			"vpand xmm2,xmm6,oword [rax]",
			"vpand ymm2,ymm6,ymm3",
			"vpand ymm2,ymm6,yword [rax]",
			"vpandd xmm2{k3}{z},xmm6,xmm3",
			"vpandd xmm2{k3},xmm6,oword [rax+0x10]",
			"vpandd xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vpandd ymm2{k3}{z},ymm6,ymm3",
			"vpandd ymm2{k3},ymm6,yword [rax+0x20]",
			"vpandd ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vpandd zmm2{k3}{z},zmm6,zmm3",
			"vpandd zmm2{k3},zmm6,zword [rax+0x40]",
			"vpandd zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
			"vpandq xmm2{k3}{z},xmm6,xmm3",
			"vpandq xmm2{k3},xmm6,oword [rax+0x10]",
			"vpandq xmm2{k5}{z},xmm6,qword [rax+8]{1to2}",
			"vpandq ymm2{k3}{z},ymm6,ymm3",
			"vpandq ymm2{k3},ymm6,yword [rax+0x20]",
			"vpandq ymm2{k5}{z},ymm6,qword [rax+8]{1to4}",
			"vpandq zmm2{k3}{z},zmm6,zmm3",
			"vpandq zmm2{k3},zmm6,zword [rax+0x40]",
			"vpandq zmm2{k5}{z},zmm6,qword [rax+8]{1to8}",
			"paddusb mm1,mm5",
			"paddusb mm1,qword [rax]",
			"paddusb xmm1,xmm5",
			"paddusb xmm1,oword [rax]",
			"vpaddusb xmm2,xmm6,xmm3",
			"vpaddusb xmm2,xmm6,oword [rax]",
			"vpaddusb ymm2,ymm6,ymm3",
			"vpaddusb ymm2,ymm6,yword [rax]",
			"vpaddusb xmm2{k3},xmm6,xmm3",
			"vpaddusb xmm2{k3},xmm6,oword [rax+0x10]",
			"vpaddusb ymm2{k3},ymm6,ymm3",
			"vpaddusb ymm2{k3},ymm6,yword [rax+0x20]",
			"vpaddusb zmm2{k3},zmm6,zmm3",
			"vpaddusb zmm2{k3},zmm6,zword [rax+0x40]",
			"paddusw mm1,mm5",
			"paddusw mm1,qword [rax]",
			"paddusw xmm1,xmm5",
			"paddusw xmm1,oword [rax]",
			"vpaddusw xmm2,xmm6,xmm3",
			"vpaddusw xmm2,xmm6,oword [rax]",
			"vpaddusw ymm2,ymm6,ymm3",
			"vpaddusw ymm2,ymm6,yword [rax]",
			"vpaddusw xmm2{k3},xmm6,xmm3",
			"vpaddusw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpaddusw ymm2{k3},ymm6,ymm3",
			"vpaddusw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpaddusw zmm2{k3},zmm6,zmm3",
			"vpaddusw zmm2{k3},zmm6,zword [rax+0x40]",
			"pmaxub mm1,mm5",
			"pmaxub mm1,qword [rax]",
			"pmaxub xmm1,xmm5",
			"pmaxub xmm1,oword [rax]",
			"vpmaxub xmm2,xmm6,xmm3",
			"vpmaxub xmm2,xmm6,oword [rax]",
			"vpmaxub ymm2,ymm6,ymm3",
			"vpmaxub ymm2,ymm6,yword [rax]",
			"vpmaxub xmm2{k3},xmm6,xmm3",
			"vpmaxub xmm2{k3},xmm6,oword [rax+0x10]",
			"vpmaxub ymm2{k3},ymm6,ymm3",
			"vpmaxub ymm2{k3},ymm6,yword [rax+0x20]",
			"vpmaxub zmm2{k3},zmm6,zmm3",
			"vpmaxub zmm2{k3},zmm6,zword [rax+0x40]",
			"pandn mm1,mm5",
			"pandn mm1,qword [rax]",
			"pandn xmm1,xmm5",
			"pandn xmm1,oword [rax]",
			"vpandn xmm2,xmm6,xmm3",
			"vpandn xmm2,xmm6,oword [rax]",
			"vpandn ymm2,ymm6,ymm3",
			"vpandn ymm2,ymm6,yword [rax]",
			"vpandnd xmm2{k3}{z},xmm6,xmm3",
			"vpandnd xmm2{k3},xmm6,oword [rax+0x10]",
			"vpandnd xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vpandnd ymm2{k3}{z},ymm6,ymm3",
			"vpandnd ymm2{k3},ymm6,yword [rax+0x20]",
			"vpandnd ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vpandnd zmm2{k3}{z},zmm6,zmm3",
			"vpandnd zmm2{k3},zmm6,zword [rax+0x40]",
			"vpandnd zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
			"vpandnq xmm2{k3}{z},xmm6,xmm3",
			"vpandnq xmm2{k3},xmm6,oword [rax+0x10]",
			"vpandnq xmm2{k5}{z},xmm6,qword [rax+8]{1to2}",
			"vpandnq ymm2{k3}{z},ymm6,ymm3",
			"vpandnq ymm2{k3},ymm6,yword [rax+0x20]",
			"vpandnq ymm2{k5}{z},ymm6,qword [rax+8]{1to4}",
			"vpandnq zmm2{k3}{z},zmm6,zmm3",
			"vpandnq zmm2{k3},zmm6,zword [rax+0x40]",
			"vpandnq zmm2{k5}{z},zmm6,qword [rax+8]{1to8}",
			"pavgb mm1,mm5",
			"pavgb mm1,qword [rax]",
			"pavgb xmm1,xmm5",
			"pavgb xmm1,oword [rax]",
			"vpavgb xmm2,xmm6,xmm3",
			"vpavgb xmm2,xmm6,oword [rax]",
			"vpavgb ymm2,ymm6,ymm3",
			"vpavgb ymm2,ymm6,yword [rax]",
			"vpavgb xmm2{k3},xmm6,xmm3",
			"vpavgb xmm2{k3},xmm6,oword [rax+0x10]",
			"vpavgb ymm2{k3},ymm6,ymm3",
			"vpavgb ymm2{k3},ymm6,yword [rax+0x20]",
			"vpavgb zmm2{k3},zmm6,zmm3",
			"vpavgb zmm2{k3},zmm6,zword [rax+0x40]",
			"psraw mm1,mm5",
			"psraw mm1,qword [rax]",
			"psraw xmm1,xmm5",
			"psraw xmm1,oword [rax]",
			"vpsraw xmm2,xmm6,xmm3",
			"vpsraw xmm2,xmm6,oword [rax]",
			"vpsraw ymm2,ymm6,xmm3",
			"vpsraw ymm2,ymm6,oword [rax]",
			"vpsraw xmm2{k3},xmm6,xmm3",
			"vpsraw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsraw ymm2{k3},ymm6,xmm3",
			"vpsraw ymm2{k3},ymm6,oword [rax+0x10]",
			"vpsraw zmm2{k3},zmm6,xmm3",
			"vpsraw zmm2{k3},zmm6,oword [rax+0x10]",
			"psrad mm1,mm5",
			"psrad mm1,qword [rax]",
			"psrad xmm1,xmm5",
			"psrad xmm1,oword [rax]",
			"vpsrad xmm2,xmm6,xmm3",
			"vpsrad xmm2,xmm6,oword [rax]",
			"vpsrad ymm2,ymm6,xmm3",
			"vpsrad ymm2,ymm6,oword [rax]",
			"vpsrad xmm2{k3},xmm6,xmm3",
			"vpsrad xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsrad ymm2{k3},ymm6,xmm3",
			"vpsrad ymm2{k3},ymm6,oword [rax+0x10]",
			"vpsrad zmm2{k3},zmm6,xmm3",
			"vpsrad zmm2{k3},zmm6,oword [rax+0x10]",
			"vpsraq xmm2{k3},xmm6,xmm3",
			"vpsraq xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsraq ymm2{k3},ymm6,xmm3",
			"vpsraq ymm2{k3},ymm6,oword [rax+0x10]",
			"vpsraq zmm2{k3},zmm6,xmm3",
			"vpsraq zmm2{k3},zmm6,oword [rax+0x10]",
			"pavgw mm1,mm5",
			"pavgw mm1,qword [rax]",
			"pavgw xmm1,xmm5",
			"pavgw xmm1,oword [rax]",
			"vpavgw xmm2,xmm6,xmm3",
			"vpavgw xmm2,xmm6,oword [rax]",
			"vpavgw ymm2,ymm6,ymm3",
			"vpavgw ymm2,ymm6,yword [rax]",
			"vpavgw xmm2{k3},xmm6,xmm3",
			"vpavgw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpavgw ymm2{k3},ymm6,ymm3",
			"vpavgw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpavgw zmm2{k3},zmm6,zmm3",
			"vpavgw zmm2{k3},zmm6,zword [rax+0x40]",
			"pmulhuw mm1,mm5",
			"pmulhuw mm1,qword [rax]",
			"pmulhuw xmm1,xmm5",
			"pmulhuw xmm1,oword [rax]",
			"vpmulhuw xmm2,xmm6,xmm3",
			"vpmulhuw xmm2,xmm6,oword [rax]",
			"vpmulhuw ymm2,ymm6,ymm3",
			"vpmulhuw ymm2,ymm6,yword [rax]",
			"vpmulhuw xmm2{k3},xmm6,xmm3",
			"vpmulhuw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpmulhuw ymm2{k3},ymm6,ymm3",
			"vpmulhuw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpmulhuw zmm2{k3},zmm6,zmm3",
			"vpmulhuw zmm2{k3},zmm6,zword [rax+0x40]",
			"pmulhw mm1,mm5",
			"pmulhw mm1,qword [rax]",
			"pmulhw xmm1,xmm5",
			"pmulhw xmm1,oword [rax]",
			"vpmulhw xmm2,xmm6,xmm3",
			"vpmulhw xmm2,xmm6,oword [rax]",
			"vpmulhw ymm2,ymm6,ymm3",
			"vpmulhw ymm2,ymm6,yword [rax]",
			"vpmulhw xmm2{k3},xmm6,xmm3",
			"vpmulhw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpmulhw ymm2{k3},ymm6,ymm3",
			"vpmulhw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpmulhw zmm2{k3},zmm6,zmm3",
			"vpmulhw zmm2{k3},zmm6,zword [rax+0x40]",
			"cvttpd2dq xmm1,xmm5",
			"cvttpd2dq xmm1,oword [rax]",
			"vcvttpd2dq xmm1,xmm5",
			"vcvttpd2dq xmm2,oword [rax]",
			"vcvttpd2dq xmm1,ymm5",
			"vcvttpd2dq xmm2,yword [rax]",
			"vcvttpd2dq xmm2{k3},xmm3",
			"vcvttpd2dq xmm2,oword [rax+0x10]",
			"vcvttpd2dq xmm2{k3}{z},qword [rax+8]{1to2}",
			"vcvttpd2dq xmm2{k3},ymm3",
			"vcvttpd2dq xmm2,yword [rax+0x20]",
			"vcvttpd2dq xmm2{k3}{z},qword [rax+8]{1to4}",
			"vcvttpd2dq ymm2{k3},zmm3",
			"vcvttpd2dq ymm2,zword [rax+0x40]",
			"vcvttpd2dq ymm2{k3}{z},qword [rax+8]{1to8}",
			"cvtdq2pd xmm1,xmm5",
			"cvtdq2pd xmm1,qword [rax]",
			"vcvtdq2pd xmm1,xmm5",
			"vcvtdq2pd xmm2,qword [rax]",
			"vcvtdq2pd ymm1,xmm5",
			"vcvtdq2pd ymm2,oword [rax]",
			"vcvtdq2pd xmm2{k3},xmm3",
			"vcvtdq2pd xmm2,qword [rax+8]",
			"vcvtdq2pd xmm2{k3}{z},dword [rax+4]{1to2}",
			"vcvtdq2pd ymm2{k3},xmm3",
			"vcvtdq2pd ymm2,oword [rax+0x10]",
			"vcvtdq2pd ymm2{k3}{z},dword [rax+4]{1to4}",
			"vcvtdq2pd zmm2{k3},ymm3",
			"vcvtdq2pd zmm2,yword [rax+0x20]",
			"vcvtdq2pd zmm2{k3}{z},dword [rax+4]{1to8}",
			"vcvtqq2pd xmm2{k3},xmm3",
			"vcvtqq2pd xmm2,oword [rax+0x10]",
			"vcvtqq2pd xmm2{k3}{z},qword [rax+8]{1to2}",
			"vcvtqq2pd ymm2{k3},ymm3",
			"vcvtqq2pd ymm2,yword [rax+0x20]",
			"vcvtqq2pd ymm2{k3}{z},qword [rax+8]{1to4}",
			"vcvtqq2pd zmm2{k3},zmm3",
			"vcvtqq2pd zmm2,zword [rax+0x40]",
			"vcvtqq2pd zmm2{k3}{z},qword [rax+8]{1to8}",
			"cvtpd2dq xmm1,xmm5",
			"cvtpd2dq xmm1,oword [rax]",
			"vcvtpd2dq xmm1,xmm5",
			"vcvtpd2dq xmm2,oword [rax]",
			"vcvtpd2dq xmm1,ymm5",
			"vcvtpd2dq xmm2,yword [rax]",
			"vcvtpd2dq xmm2{k3},xmm3",
			"vcvtpd2dq xmm2,oword [rax+0x10]",
			"vcvtpd2dq xmm2{k3}{z},qword [rax+8]{1to2}",
			"vcvtpd2dq xmm2{k3},ymm3",
			"vcvtpd2dq xmm2,yword [rax+0x20]",
			"vcvtpd2dq xmm2{k3}{z},qword [rax+8]{1to4}",
			"vcvtpd2dq ymm2{k3},zmm3",
			"vcvtpd2dq ymm2,zword [rax+0x40]",
			"vcvtpd2dq ymm2{k3}{z},qword [rax+8]{1to8}",
			"movntq qword [rax],mm1",
			"movntdq oword [rax],xmm1",
			"vmovntdq oword [rax],xmm2",
			"vmovntdq yword [rax],ymm2",
			"vmovntdq oword [rax+0x10],xmm2",
			"vmovntdq yword [rax+0x20],ymm2",
			"vmovntdq zword [rax+0x40],zmm2",
			"psubsb mm1,mm5",
			"psubsb mm1,qword [rax]",
			"psubsb xmm1,xmm5",
			"psubsb xmm1,oword [rax]",
			"vpsubsb xmm2,xmm6,xmm3",
			"vpsubsb xmm2,xmm6,oword [rax]",
			"vpsubsb ymm2,ymm6,ymm3",
			"vpsubsb ymm2,ymm6,yword [rax]",
			"vpsubsb xmm2{k3},xmm6,xmm3",
			"vpsubsb xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsubsb ymm2{k3},ymm6,ymm3",
			"vpsubsb ymm2{k3},ymm6,yword [rax+0x20]",
			"vpsubsb zmm2{k3},zmm6,zmm3",
			"vpsubsb zmm2{k3},zmm6,zword [rax+0x40]",
			"psubsw mm1,mm5",
			"psubsw mm1,qword [rax]",
			"psubsw xmm1,xmm5",
			"psubsw xmm1,oword [rax]",
			"vpsubsw xmm2,xmm6,xmm3",
			"vpsubsw xmm2,xmm6,oword [rax]",
			"vpsubsw ymm2,ymm6,ymm3",
			"vpsubsw ymm2,ymm6,yword [rax]",
			"vpsubsw xmm2{k3},xmm6,xmm3",
			"vpsubsw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsubsw ymm2{k3},ymm6,ymm3",
			"vpsubsw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpsubsw zmm2{k3},zmm6,zmm3",
			"vpsubsw zmm2{k3},zmm6,zword [rax+0x40]",
			"pminsw mm1,mm5",
			"pminsw mm1,qword [rax]",
			"pminsw xmm1,xmm5",
			"pminsw xmm1,oword [rax]",
			"vpminsw xmm2,xmm6,xmm3",
			"vpminsw xmm2,xmm6,oword [rax]",
			"vpminsw ymm2,ymm6,ymm3",
			"vpminsw ymm2,ymm6,yword [rax]",
			"vpminsw xmm2{k3},xmm6,xmm3",
			"vpminsw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpminsw ymm2{k3},ymm6,ymm3",
			"vpminsw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpminsw zmm2{k3},zmm6,zmm3",
			"vpminsw zmm2{k3},zmm6,zword [rax+0x40]",
			"por mm1,mm5",
			"por mm1,qword [rax]",
			"por xmm1,xmm5",
			"por xmm1,oword [rax]",
			"vpor xmm2,xmm6,xmm3",
			"vpor xmm2,xmm6,oword [rax]",
			"vpor ymm2,ymm6,ymm3",
			"vpor ymm2,ymm6,yword [rax]",
			"vpord xmm2{k3}{z},xmm6,xmm3",
			"vpord xmm2{k3},xmm6,oword [rax+0x10]",
			"vpord xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vpord ymm2{k3}{z},ymm6,ymm3",
			"vpord ymm2{k3},ymm6,yword [rax+0x20]",
			"vpord ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vpord zmm2{k3}{z},zmm6,zmm3",
			"vpord zmm2{k3},zmm6,zword [rax+0x40]",
			"vpord zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
			"vporq xmm2{k3}{z},xmm6,xmm3",
			"vporq xmm2{k3},xmm6,oword [rax+0x10]",
			"vporq xmm2{k5}{z},xmm6,qword [rax+8]{1to2}",
			"vporq ymm2{k3}{z},ymm6,ymm3",
			"vporq ymm2{k3},ymm6,yword [rax+0x20]",
			"vporq ymm2{k5}{z},ymm6,qword [rax+8]{1to4}",
			"vporq zmm2{k3}{z},zmm6,zmm3",
			"vporq zmm2{k3},zmm6,zword [rax+0x40]",
			"vporq zmm2{k5}{z},zmm6,qword [rax+8]{1to8}",
			"paddsb mm1,mm5",
			"paddsb mm1,qword [rax]",
			"paddsb xmm1,xmm5",
			"paddsb xmm1,oword [rax]",
			"vpaddsb xmm2,xmm6,xmm3",
			"vpaddsb xmm2,xmm6,oword [rax]",
			"vpaddsb ymm2,ymm6,ymm3",
			"vpaddsb ymm2,ymm6,yword [rax]",
			"vpaddsb xmm2{k3},xmm6,xmm3",
			"vpaddsb xmm2{k3},xmm6,oword [rax+0x10]",
			"vpaddsb ymm2{k3},ymm6,ymm3",
			"vpaddsb ymm2{k3},ymm6,yword [rax+0x20]",
			"vpaddsb zmm2{k3},zmm6,zmm3",
			"vpaddsb zmm2{k3},zmm6,zword [rax+0x40]",
			"paddsw mm1,mm5",
			"paddsw mm1,qword [rax]",
			"paddsw xmm1,xmm5",
			"paddsw xmm1,oword [rax]",
			"vpaddsw xmm2,xmm6,xmm3",
			"vpaddsw xmm2,xmm6,oword [rax]",
			"vpaddsw ymm2,ymm6,ymm3",
			"vpaddsw ymm2,ymm6,yword [rax]",
			"vpaddsw xmm2{k3},xmm6,xmm3",
			"vpaddsw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpaddsw ymm2{k3},ymm6,ymm3",
			"vpaddsw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpaddsw zmm2{k3},zmm6,zmm3",
			"vpaddsw zmm2{k3},zmm6,zword [rax+0x40]",
			"pmaxsw mm1,mm5",
			"pmaxsw mm1,qword [rax]",
			"pmaxsw xmm1,xmm5",
			"pmaxsw xmm1,oword [rax]",
			"vpmaxsw xmm2,xmm6,xmm3",
			"vpmaxsw xmm2,xmm6,oword [rax]",
			"vpmaxsw ymm2,ymm6,ymm3",
			"vpmaxsw ymm2,ymm6,yword [rax]",
			"vpmaxsw xmm2{k3},xmm6,xmm3",
			"vpmaxsw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpmaxsw ymm2{k3},ymm6,ymm3",
			"vpmaxsw ymm2{k3},ymm6,yword [rax+0x20]",
			"vpmaxsw zmm2{k3},zmm6,zmm3",
			"vpmaxsw zmm2{k3},zmm6,zword [rax+0x40]",
			"pxor mm1,mm5",
			"pxor mm1,qword [rax]",
			"pxor xmm1,xmm5",
			"pxor xmm1,oword [rax]",
			"vpxor xmm2,xmm6,xmm3",
			"vpxor xmm2,xmm6,oword [rax]",
			"vpxor ymm2,ymm6,ymm3",
			"vpxor ymm2,ymm6,yword [rax]",
			"vpxord xmm2{k3}{z},xmm6,xmm3",
			"vpxord xmm2{k3},xmm6,oword [rax+0x10]",
			"vpxord xmm2{k5}{z},xmm6,dword [rax+4]{1to4}",
			"vpxord ymm2{k3}{z},ymm6,ymm3",
			"vpxord ymm2{k3},ymm6,yword [rax+0x20]",
			"vpxord ymm2{k5}{z},ymm6,dword [rax+4]{1to8}",
			"vpxord zmm2{k3}{z},zmm6,zmm3",
			"vpxord zmm2{k3},zmm6,zword [rax+0x40]",
			"vpxord zmm2{k5}{z},zmm6,dword [rax+4]{1to16}",
			"vpxorq xmm2{k3}{z},xmm6,xmm3",
			"vpxorq xmm2{k3},xmm6,oword [rax+0x10]",
			"vpxorq xmm2{k5}{z},xmm6,qword [rax+8]{1to2}",
			"vpxorq ymm2{k3}{z},ymm6,ymm3",
			"vpxorq ymm2{k3},ymm6,yword [rax+0x20]",
			"vpxorq ymm2{k5}{z},ymm6,qword [rax+8]{1to4}",
			"vpxorq zmm2{k3}{z},zmm6,zmm3",
			"vpxorq zmm2{k3},zmm6,zword [rax+0x40]",
			"vpxorq zmm2{k5}{z},zmm6,qword [rax+8]{1to8}",
			"lddqu xmm1,oword [rax]",
			"vlddqu xmm2,oword [rax]",
			"vlddqu ymm2,yword [rax]",
			"psllw mm1,mm5",
			"psllw mm1,qword [rax]",
			"psllw xmm1,xmm5",
			"psllw xmm1,oword [rax]",
			"vpsllw xmm2,xmm6,xmm3",
			"vpsllw xmm2,xmm6,oword [rax]",
			"vpsllw ymm2,ymm6,xmm3",
			"vpsllw ymm2,ymm6,oword [rax]",
			"vpsllw xmm2{k3},xmm6,xmm3",
			"vpsllw xmm2{k3},xmm6,oword [rax+0x10]",
			"vpsllw ymm2{k3},ymm6,xmm3",
		};
	}
}
#endif
