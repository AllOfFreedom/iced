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

#if !NO_GAS_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Gas {
	public sealed class GasFormatterTest64_ForceSuffix_001 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_ForceSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_001.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_001.AllInfos_Length] {
			"idivb (rax)",
			"testw $-0x5aa6,cx",
			"testw $-0x5aa6,(rax)",
			"testl $0x3412a55a,ecx",
			"testl $0x3412a55a,(rax)",
			"testq $-0x7bed5aa6,rcx",
			"testq $-0x7bed5aa6,(rax)",
			"notw cx",
			"notw (rax)",
			"notl ecx",
			"notl (rax)",
			"notq rcx",
			"notq (rax)",
			"negw si",
			"negw (rax)",
			"negl esi",
			"negl (rax)",
			"negq rsi",
			"negq (rax)",
			"mulw bp",
			"mulw (rax)",
			"mull ebp",
			"mull (rax)",
			"mulq rbp",
			"mulq (rax)",
			"imulw si",
			"imulw (rax)",
			"imull esi",
			"imull (rax)",
			"imulq rsi",
			"imulq (rax)",
			"divw di",
			"divw (rax)",
			"divl edi",
			"divl (rax)",
			"divq rdi",
			"divq (rax)",
			"idivw ax",
			"idivw (rax)",
			"idivl eax",
			"idivl (rax)",
			"idivq r8",
			"idivq (rax)",
			"clc",
			"stc",
			"cli",
			"sti",
			"cld",
			"std",
			"incb cl",
			"incb (rax)",
			"decb dh",
			"decb (rax)",
			"incw cx",
			"incw (rax)",
			"incl ecx",
			"incl (rax)",
			"incq rcx",
			"incq (rax)",
			"decw si",
			"decw (rax)",
			"decl esi",
			"decl (rax)",
			"decq rsi",
			"decq (rax)",
			"callq *rcx",
			"callq *(rax)",
			"lcallw *(rax)",
			"lcalll *(rax)",
			"rex.w lcall *(rax)",
			"jmpq *rsi",
			"jmpq *(rax)",
			"ljmpw *(rax)",
			"ljmpl *(rax)",
			"rex.w ljmp *(rax)",
			"pushw si",
			"pushw (rax)",
			"pushq rsi",
			"pushq (rax)",
			"sldtw cx",
			"data16 sldt (rax)",
			"sldtl ecx",
			"sldt (rax)",
			"sldtq rcx",
			"rex.w sldt (rax)",
			"strw dx",
			"data16 str (rax)",
			"strl edx",
			"str (rax)",
			"strq rdx",
			"rex.w str (rax)",
			"data16 lldt bx",
			"data16 lldt (rax)",
			"lldt bx",
			"lldt (rax)",
			"rex.w lldt bx",
			"rex.w lldt (rax)",
			"data16 ltr sp",
			"data16 ltr (rax)",
			"ltr sp",
			"ltr (rax)",
			"rex.w ltr sp",
			"rex.w ltr (rax)",
			"data16 verr bp",
			"data16 verr (rax)",
			"verr bp",
			"verr (rax)",
			"rex.w verr bp",
			"rex.w verr (rax)",
			"data16 verw si",
			"data16 verw (rax)",
			"verw si",
			"verw (rax)",
			"rex.w verw si",
			"rex.w verw (rax)",
			"sgdtq (rax)",
			"sidtq (rax)",
			"lgdtq (rax)",
			"lidtq (rax)",
			"smsww bp",
			"data16 smsw (rax)",
			"smswl ebp",
			"smsw (rax)",
			"smswq rbp",
			"rex.w smsw (rax)",
			"data16 lmsw si",
			"data16 lmsw (rax)",
			"lmsw si",
			"lmsw (rax)",
			"rex.w lmsw si",
			"rex.w lmsw (rax)",
			"invlpg (rax)",
			"enclv",
			"vmcall",
			"vmlaunch",
			"vmresume",
			"vmxoff",
			"monitor",
			"mwait",
			"clac",
			"stac",
			"encls",
			"xgetbv",
			"xsetbv",
			"vmfunc",
			"xend",
			"xtest",
			"enclu",
			"rdpkru",
			"wrpkru",
			"swapgs",
			"rdtscp",
			"larw si,cx",
			"larw (rax),bx",
			"larl esi,ecx",
			"larl (rax),ebx",
			"larq rsi,rcx",
			"larq (rax),rbx",
			"lslw si,cx",
			"lslw (rax),bx",
			"lsll esi,ecx",
			"lsll (rax),ebx",
			"lslq rsi,rcx",
			"lslq (rax),rbx",
			"syscall",
			"clts",
			"sysret",
			"sysretq",
			"invd",
			"wbinvd",
			"ud2",
			"prefetchw (rax)",
			"prefetchwt1 (rax)",
			"movups xmm5,xmm1",
			"movups (rax),xmm1",
			"vmovups xmm5,xmm1",
			"vmovups (rax),xmm2",
			"vmovups ymm5,ymm1",
			"vmovups (rax),ymm2",
			"vmovups xmm3,xmm2",
			"vmovups 0x10(rax),xmm2",
			"vmovups ymm3,ymm2",
			"vmovups 0x20(rax),ymm2",
			"vmovups zmm3,zmm2",
			"vmovups 0x40(rax),zmm2",
			"movupd xmm5,xmm1",
			"movupd (rax),xmm1",
			"vmovupd xmm5,xmm1",
			"vmovupd (rax),xmm2",
			"vmovupd ymm5,ymm1",
			"vmovupd (rax),ymm2",
			"vmovupd xmm3,xmm2",
			"vmovupd 0x10(rax),xmm2",
			"vmovupd ymm3,ymm2",
			"vmovupd 0x20(rax),ymm2",
			"vmovupd zmm3,zmm2",
			"vmovupd 0x40(rax),zmm2",
			"movss xmm5,xmm1",
			"movss (rax),xmm1",
			"vmovss xmm5,xmm6,xmm1",
			"vmovss (rax),xmm2",
			"vmovss xmm3,xmm6,xmm2",
			"vmovss 4(rax),xmm2",
			"movsd xmm5,xmm1",
			"movsd (rax),xmm1",
			"vmovsd xmm5,xmm6,xmm1",
			"vmovsd (rax),xmm2",
			"vmovsd xmm3,xmm6,xmm2",
			"vmovsd 8(rax),xmm2",
			"movups xmm1,xmm5",
			"movups xmm1,(rax)",
			"vmovups xmm1,xmm5",
			"vmovups xmm2,(rax)",
			"vmovups ymm1,ymm5",
			"vmovups ymm2,(rax)",
			"vmovups xmm2,xmm3",
			"vmovups xmm2,0x10(rax)",
			"vmovups ymm2,ymm3",
			"vmovups ymm2,0x20(rax)",
			"vmovups zmm2,zmm3",
			"vmovups zmm2,0x40(rax)",
			"movupd xmm1,xmm5",
			"movupd xmm1,(rax)",
			"vmovupd xmm1,xmm5",
			"vmovupd xmm2,(rax)",
			"vmovupd ymm1,ymm5",
			"vmovupd ymm2,(rax)",
			"vmovupd xmm2,xmm3",
			"vmovupd xmm2,0x10(rax)",
			"vmovupd ymm2,ymm3",
			"vmovupd ymm2,0x20(rax)",
			"vmovupd zmm2,zmm3",
			"vmovupd zmm2,0x40(rax)",
			"movss xmm1,xmm5",
			"movss xmm1,(rax)",
			"vmovss xmm1,xmm6,xmm5",
			"vmovss xmm2,(rax)",
			"vmovss xmm2,xmm6,xmm3",
			"vmovss xmm2,4(rax)",
			"movsd xmm1,xmm5",
			"movsd xmm1,(rax)",
			"vmovsd xmm1,xmm6,xmm5",
			"vmovsd xmm2,(rax)",
			"vmovsd xmm2,xmm6,xmm3",
			"vmovsd xmm2,8(rax)",
			"movhlps xmm5,xmm1",
			"movlps (rax),xmm1",
			"vmovhlps xmm3,xmm6,xmm2",
			"vmovlps (rax),xmm6,xmm2",
			"vmovhlps xmm3,xmm6,xmm2",
			"vmovlps 8(rax),xmm6,xmm2",
			"movlpd (rax),xmm1",
			"vmovlpd (rax),xmm6,xmm2",
			"vmovlpd 8(rax),xmm6,xmm2",
			"movsldup xmm5,xmm1",
			"movsldup (rax),xmm1",
			"vmovsldup xmm5,xmm1",
			"vmovsldup (rax),xmm2",
			"vmovsldup ymm5,ymm1",
			"vmovsldup (rax),ymm2",
			"vmovsldup xmm3,xmm2",
			"vmovsldup 0x10(rax),xmm2",
			"vmovsldup ymm3,ymm2",
			"vmovsldup 0x20(rax),ymm2",
			"vmovsldup zmm3,zmm2",
			"vmovsldup 0x40(rax),zmm2",
			"movddup xmm5,xmm1",
			"movddup (rax),xmm1",
			"vmovddup xmm5,xmm1",
			"vmovddup (rax),xmm2",
			"vmovddup ymm5,ymm1",
			"vmovddup (rax),ymm2",
			"vmovddup xmm3,xmm2",
			"vmovddup 8(rax),xmm2",
			"vmovddup ymm3,ymm2",
			"vmovddup 0x20(rax),ymm2",
			"vmovddup zmm3,zmm2",
			"vmovddup 0x40(rax),zmm2",
			"movlps xmm1,(rax)",
			"vmovlps xmm2,(rax)",
			"vmovlps xmm2,8(rax)",
			"movlpd xmm1,(rax)",
			"vmovlpd xmm2,(rax)",
			"vmovlpd xmm2,8(rax)",
			"unpcklps xmm5,xmm1",
			"unpcklps (rax),xmm1",
			"vunpcklps xmm3,xmm6,xmm2",
			"vunpcklps (rax),xmm6,xmm2",
			"vunpcklps ymm3,ymm6,ymm2",
			"vunpcklps (rax),ymm6,ymm2",
			"vunpcklps xmm3,xmm6,xmm2{k3}",
			"vunpcklps 0x10(rax),xmm6,xmm2{k3}",
			"vunpcklps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vunpcklps ymm3,ymm6,ymm2{k3}",
			"vunpcklps 0x20(rax),ymm6,ymm2{k3}",
			"vunpcklps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vunpcklps zmm3,zmm6,zmm2{k3}",
			"vunpcklps 0x40(rax),zmm6,zmm2{k3}",
			"vunpcklps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"unpcklpd xmm5,xmm1",
			"unpcklpd (rax),xmm1",
			"vunpcklpd xmm3,xmm6,xmm2",
			"vunpcklpd (rax),xmm6,xmm2",
			"vunpcklpd ymm3,ymm6,ymm2",
			"vunpcklpd (rax),ymm6,ymm2",
			"vunpcklpd xmm3,xmm6,xmm2{k3}{z}",
			"vunpcklpd 0x10(rax),xmm6,xmm2{k3}",
			"vunpcklpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vunpcklpd ymm3,ymm6,ymm2{k3}{z}",
			"vunpcklpd 0x20(rax),ymm6,ymm2{k3}",
			"vunpcklpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vunpcklpd zmm3,zmm6,zmm2{k3}{z}",
			"vunpcklpd 0x40(rax),zmm6,zmm2{k3}",
			"vunpcklpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"unpckhps xmm5,xmm1",
			"unpckhps (rax),xmm1",
			"vunpckhps xmm3,xmm6,xmm2",
			"vunpckhps (rax),xmm6,xmm2",
			"vunpckhps ymm3,ymm6,ymm2",
			"vunpckhps (rax),ymm6,ymm2",
			"vunpckhps xmm3,xmm6,xmm2{k3}",
			"vunpckhps 0x10(rax),xmm6,xmm2{k3}",
			"vunpckhps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vunpckhps ymm3,ymm6,ymm2{k3}",
			"vunpckhps 0x20(rax),ymm6,ymm2{k3}",
			"vunpckhps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vunpckhps zmm3,zmm6,zmm2{k3}",
			"vunpckhps 0x40(rax),zmm6,zmm2{k3}",
			"vunpckhps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"unpckhpd xmm5,xmm1",
			"unpckhpd (rax),xmm1",
			"vunpckhpd xmm3,xmm6,xmm2",
			"vunpckhpd (rax),xmm6,xmm2",
			"vunpckhpd ymm3,ymm6,ymm2",
			"vunpckhpd (rax),ymm6,ymm2",
			"vunpckhpd xmm3,xmm6,xmm2{k3}{z}",
			"vunpckhpd 0x10(rax),xmm6,xmm2{k3}",
			"vunpckhpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vunpckhpd ymm3,ymm6,ymm2{k3}{z}",
			"vunpckhpd 0x20(rax),ymm6,ymm2{k3}",
			"vunpckhpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vunpckhpd zmm3,zmm6,zmm2{k3}{z}",
			"vunpckhpd 0x40(rax),zmm6,zmm2{k3}",
			"vunpckhpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"movlhps xmm5,xmm1",
			"vmovlhps xmm3,xmm6,xmm2",
			"vmovlhps xmm3,xmm6,xmm2",
			"movhps (rax),xmm1",
			"vmovhps (rax),xmm6,xmm2",
			"vmovhps 8(rax),xmm6,xmm2",
			"movhpd (rax),xmm1",
			"vmovhpd (rax),xmm6,xmm2",
			"vmovhpd 8(rax),xmm6,xmm2",
			"movshdup xmm5,xmm1",
			"movshdup (rax),xmm1",
			"vmovshdup xmm5,xmm1",
			"vmovshdup (rax),xmm2",
			"vmovshdup ymm5,ymm1",
			"vmovshdup (rax),ymm2",
			"vmovshdup xmm3,xmm2",
			"vmovshdup 0x10(rax),xmm2",
			"vmovshdup ymm3,ymm2",
			"vmovshdup 0x20(rax),ymm2",
			"vmovshdup zmm3,zmm2",
			"vmovshdup 0x40(rax),zmm2",
			"movhps xmm1,(rax)",
			"vmovhps xmm2,(rax)",
			"vmovhps xmm2,8(rax)",
			"movhpd xmm1,(rax)",
			"vmovhpd xmm2,(rax)",
			"vmovhpd xmm2,8(rax)",
			"prefetchnta (rax)",
			"prefetcht0 (rax)",
			"prefetcht1 (rax)",
			"prefetcht2 (rax)",
			"bndldx (rax),bnd1",
			"bndmov bnd2,bnd1",
			"bndmov (rax),bnd1",
			"bndcl rdx,bnd1",
			"bndcl (rax),bnd1",
			"bndcu rdx,bnd1",
			"bndcu (rax),bnd1",
			"bndstx bnd1,(rax)",
			"bndmov bnd1,bnd2",
			"bndmov bnd1,(rax)",
			"bndmk (rax),bnd1",
			"bndcn rdx,bnd1",
			"bndcn (rax),bnd1",
			"nopw cx",
			"nopw (rax)",
			"nopl ecx",
			"nopl (rax)",
			"nopq rcx",
			"nopq (rax)",
			"movq cr3,rsi",
			"movq db3,rsi",
			"movq rsi,cr3",
			"movq rsi,db3",
			"movaps xmm5,xmm1",
			"movaps (rax),xmm1",
			"vmovaps xmm5,xmm1",
			"vmovaps (rax),xmm2",
			"vmovaps ymm5,ymm1",
			"vmovaps (rax),ymm2",
			"vmovaps xmm3,xmm2",
			"vmovaps 0x10(rax),xmm2",
			"vmovaps ymm3,ymm2",
			"vmovaps 0x20(rax),ymm2",
			"vmovaps zmm3,zmm2",
			"vmovaps 0x40(rax),zmm2",
			"movapd xmm5,xmm1",
			"movapd (rax),xmm1",
			"vmovapd xmm5,xmm1",
			"vmovapd (rax),xmm2",
			"vmovapd ymm5,ymm1",
			"vmovapd (rax),ymm2",
			"vmovapd xmm3,xmm2",
			"vmovapd 0x10(rax),xmm2",
			"vmovapd ymm3,ymm2",
			"vmovapd 0x20(rax),ymm2",
			"vmovapd zmm3,zmm2",
			"vmovapd 0x40(rax),zmm2",
			"movaps xmm1,xmm5",
			"movaps xmm1,(rax)",
			"vmovaps xmm1,xmm5",
			"vmovaps xmm2,(rax)",
			"vmovaps ymm1,ymm5",
			"vmovaps ymm2,(rax)",
			"vmovaps xmm2,xmm3",
			"vmovaps xmm2,0x10(rax)",
			"vmovaps ymm2,ymm3",
			"vmovaps ymm2,0x20(rax)",
			"vmovaps zmm2,zmm3",
			"vmovaps zmm2,0x40(rax)",
			"movapd xmm1,xmm5",
			"movapd xmm1,(rax)",
			"vmovapd xmm1,xmm5",
			"vmovapd xmm2,(rax)",
			"vmovapd ymm1,ymm5",
			"vmovapd ymm2,(rax)",
			"vmovapd xmm2,xmm3",
			"vmovapd xmm2,0x10(rax)",
			"vmovapd ymm2,ymm3",
			"vmovapd ymm2,0x20(rax)",
			"vmovapd zmm2,zmm3",
			"vmovapd zmm2,0x40(rax)",
			"cvtpi2ps mm5,xmm1",
			"cvtpi2ps (rax),xmm1",
			"cvtpi2pd mm5,xmm1",
			"cvtpi2pd (rax),xmm1",
			"cvtsi2ssl ebp,xmm1",
			"cvtsi2ssl (rax),xmm1",
			"cvtsi2ssq rbp,xmm1",
			"cvtsi2ssq (rax),xmm1",
			"vcvtsi2ssl ebx,xmm6,xmm2",
			"vcvtsi2ssl (rax),xmm6,xmm2",
			"vcvtsi2ssq rbx,xmm6,xmm2",
			"vcvtsi2ssq (rax),xmm6,xmm2",
			"vcvtsi2ssl ebx,xmm6,xmm2",
			"vcvtsi2ssl 4(rax),xmm6,xmm2",
			"vcvtsi2ssq rbx,xmm6,xmm2",
			"vcvtsi2ssq 8(rax),xmm6,xmm2",
			"cvtsi2sdl ebp,xmm1",
			"cvtsi2sdl (rax),xmm1",
			"cvtsi2sdq rbp,xmm1",
			"cvtsi2sdq (rax),xmm1",
			"vcvtsi2sdl ebx,xmm6,xmm2",
			"vcvtsi2sdl (rax),xmm6,xmm2",
			"vcvtsi2sdq rbx,xmm6,xmm2",
			"vcvtsi2sdq (rax),xmm6,xmm2",
			"vcvtsi2sdl ebx,xmm6,xmm2",
			"vcvtsi2sdl 4(rax),xmm6,xmm2",
			"vcvtsi2sdq rbx,xmm6,xmm2",
			"vcvtsi2sdq 8(rax),xmm6,xmm2",
			"movntps xmm1,(rax)",
			"vmovntps xmm2,(rax)",
			"vmovntps ymm2,(rax)",
			"vmovntps xmm2,0x10(rax)",
			"vmovntps ymm2,0x20(rax)",
			"vmovntps zmm2,0x40(rax)",
			"movntpd xmm1,(rax)",
			"vmovntpd xmm2,(rax)",
			"vmovntpd ymm2,(rax)",
			"vmovntpd xmm2,0x10(rax)",
			"vmovntpd ymm2,0x20(rax)",
			"vmovntpd zmm2,0x40(rax)",
			"cvttps2pi xmm5,mm1",
			"cvttps2pi (rax),mm1",
			"cvttpd2pi xmm5,mm1",
			"cvttpd2pi (rax),mm1",
			"cvttss2si xmm5,ecx",
			"cvttss2si (rax),ecx",
			"cvttss2si xmm5,rcx",
			"cvttss2si (rax),rcx",
			"vcvttss2si xmm5,ecx",
			"vcvttss2si (rax),edx",
			"vcvttss2si xmm5,rcx",
			"vcvttss2si (rax),rdx",
			"vcvttss2si xmm3,edx",
			"vcvttss2si 4(rax),edx",
			"vcvttss2si xmm3,rdx",
			"vcvttss2si 4(rax),rdx",
			"cvttsd2si xmm5,ecx",
			"cvttsd2si (rax),ecx",
			"cvttsd2si xmm5,rcx",
			"cvttsd2si (rax),rcx",
			"vcvttsd2si xmm5,ecx",
			"vcvttsd2si (rax),edx",
			"vcvttsd2si xmm5,rcx",
			"vcvttsd2si (rax),rdx",
			"vcvttsd2si xmm3,edx",
			"vcvttsd2si 8(rax),edx",
			"vcvttsd2si xmm3,rdx",
			"vcvttsd2si 8(rax),rdx",
			"cvtps2pi xmm5,mm1",
			"cvtps2pi (rax),mm1",
			"cvtpd2pi xmm5,mm1",
			"cvtpd2pi (rax),mm1",
			"cvtss2si xmm5,ecx",
			"cvtss2si (rax),ecx",
			"cvtss2si xmm5,rcx",
			"cvtss2si (rax),rcx",
			"vcvtss2si xmm5,ecx",
			"vcvtss2si (rax),edx",
			"vcvtss2si xmm5,rcx",
			"vcvtss2si (rax),rdx",
			"vcvtss2si xmm3,edx",
			"vcvtss2si 4(rax),edx",
			"vcvtss2si xmm3,rdx",
			"vcvtss2si 4(rax),rdx",
			"cvtsd2si xmm5,ecx",
			"cvtsd2si (rax),ecx",
			"cvtsd2si xmm5,rcx",
			"cvtsd2si (rax),rcx",
			"vcvtsd2si xmm5,ecx",
			"vcvtsd2si (rax),edx",
			"vcvtsd2si xmm5,rcx",
			"vcvtsd2si (rax),rdx",
			"vcvtsd2si xmm3,edx",
			"vcvtsd2si 8(rax),edx",
			"vcvtsd2si xmm3,rdx",
			"vcvtsd2si 8(rax),rdx",
			"ucomiss xmm5,xmm1",
			"ucomiss (rax),xmm1",
			"vucomiss xmm3,xmm2",
			"vucomiss (rax),xmm2",
			"vucomiss xmm3,xmm2",
			"vucomiss 4(rax),xmm2",
			"ucomisd xmm5,xmm1",
			"ucomisd (rax),xmm1",
			"vucomisd xmm3,xmm2",
			"vucomisd (rax),xmm2",
			"vucomisd xmm3,xmm2",
			"vucomisd 8(rax),xmm2",
			"comiss xmm5,xmm1",
			"comiss (rax),xmm1",
			"comisd xmm5,xmm1",
			"comisd (rax),xmm1",
			"vcomiss xmm3,xmm2",
			"vcomiss (rax),xmm2",
			"vcomisd xmm3,xmm2",
			"vcomisd (rax),xmm2",
			"vcomiss xmm3,xmm2",
			"vcomiss 4(rax),xmm2",
			"vcomisd xmm3,xmm2",
			"vcomisd 8(rax),xmm2",
			"wrmsr",
			"rdtsc",
			"rdmsr",
			"rdpmc",
			"sysenter",
			"sysexit",
			"rex.w sysexit",
			"getsec",
			"cmovow si,cx",
			"cmovow (rax),bx",
			"cmovol esi,ecx",
			"cmovol (rax),ebx",
			"cmovoq rsi,rcx",
			"cmovoq (rax),rbx",
			"cmovnow si,cx",
			"cmovnow (rax),bx",
			"cmovnol esi,ecx",
			"cmovnol (rax),ebx",
			"cmovnoq rsi,rcx",
			"cmovnoq (rax),rbx",
			"cmovbw si,cx",
			"cmovbw (rax),bx",
			"cmovbl esi,ecx",
			"cmovbl (rax),ebx",
			"cmovbq rsi,rcx",
			"cmovbq (rax),rbx",
			"cmovaew si,cx",
			"cmovaew (rax),bx",
			"cmovael esi,ecx",
			"cmovael (rax),ebx",
			"cmovaeq rsi,rcx",
			"cmovaeq (rax),rbx",
			"cmovew si,cx",
			"cmovew (rax),bx",
			"cmovel esi,ecx",
			"cmovel (rax),ebx",
			"cmoveq rsi,rcx",
			"cmoveq (rax),rbx",
			"cmovnew si,cx",
			"cmovnew (rax),bx",
			"cmovnel esi,ecx",
			"cmovnel (rax),ebx",
			"cmovneq rsi,rcx",
			"cmovneq (rax),rbx",
			"cmovbew si,cx",
			"cmovbew (rax),bx",
			"cmovbel esi,ecx",
			"cmovbel (rax),ebx",
			"cmovbeq rsi,rcx",
			"cmovbeq (rax),rbx",
			"cmovaw si,cx",
			"cmovaw (rax),bx",
			"cmoval esi,ecx",
			"cmoval (rax),ebx",
			"cmovaq rsi,rcx",
			"cmovaq (rax),rbx",
			"cmovsw si,cx",
			"cmovsw (rax),bx",
			"cmovsl esi,ecx",
			"cmovsl (rax),ebx",
			"cmovsq rsi,rcx",
			"cmovsq (rax),rbx",
			"cmovnsw si,cx",
			"cmovnsw (rax),bx",
			"cmovnsl esi,ecx",
			"cmovnsl (rax),ebx",
			"cmovnsq rsi,rcx",
			"cmovnsq (rax),rbx",
			"cmovpw si,cx",
			"cmovpw (rax),bx",
			"cmovpl esi,ecx",
			"cmovpl (rax),ebx",
			"cmovpq rsi,rcx",
			"cmovpq (rax),rbx",
			"cmovnpw si,cx",
			"cmovnpw (rax),bx",
			"cmovnpl esi,ecx",
			"cmovnpl (rax),ebx",
			"cmovnpq rsi,rcx",
			"cmovnpq (rax),rbx",
			"cmovlw si,cx",
			"cmovlw (rax),bx",
			"cmovll esi,ecx",
			"cmovll (rax),ebx",
			"cmovlq rsi,rcx",
			"cmovlq (rax),rbx",
			"cmovgew si,cx",
			"cmovgew (rax),bx",
			"cmovgel esi,ecx",
			"cmovgel (rax),ebx",
			"cmovgeq rsi,rcx",
			"cmovgeq (rax),rbx",
			"cmovlew si,cx",
			"cmovlew (rax),bx",
			"cmovlel esi,ecx",
			"cmovlel (rax),ebx",
			"cmovleq rsi,rcx",
			"cmovleq (rax),rbx",
			"cmovgw si,cx",
			"cmovgw (rax),bx",
			"cmovgl esi,ecx",
			"cmovgl (rax),ebx",
			"cmovgq rsi,rcx",
			"cmovgq (rax),rbx",
			"kandw k3,k6,k2",
			"kandq k3,k6,k2",
			"kandb k3,k6,k2",
			"kandd k3,k6,k2",
			"kandnw k3,k6,k2",
			"kandnq k3,k6,k2",
			"kandnb k3,k6,k2",
			"kandnd k3,k6,k2",
			"knotw k3,k2",
			"knotq k3,k2",
			"knotb k3,k2",
			"knotd k3,k2",
			"korw k3,k6,k2",
			"korq k3,k6,k2",
			"korb k3,k6,k2",
			"kord k3,k6,k2",
			"kxnorw k3,k6,k2",
			"kxnorq k3,k6,k2",
			"kxnorb k3,k6,k2",
			"kxnord k3,k6,k2",
			"kxorw k3,k6,k2",
			"kxorq k3,k6,k2",
			"kxorb k3,k6,k2",
			"kxord k3,k6,k2",
			"kaddw k3,k6,k2",
			"kaddq k3,k6,k2",
			"kaddb k3,k6,k2",
			"kaddd k3,k6,k2",
			"kunpckwd k3,k6,k2",
			"kunpckdq k3,k6,k2",
			"kunpckbw k3,k6,k2",
			"movmskps xmm5,ecx",
			"movmskps xmm5,rcx",
			"vmovmskps xmm3,edx",
			"vmovmskps xmm3,rdx",
			"vmovmskps ymm3,edx",
			"vmovmskps ymm3,rdx",
			"movmskpd xmm5,ecx",
			"movmskpd xmm5,rcx",
			"vmovmskpd xmm3,edx",
			"vmovmskpd xmm3,rdx",
			"vmovmskpd ymm3,edx",
			"vmovmskpd ymm3,rdx",
			"sqrtps xmm5,xmm1",
			"sqrtps (rax),xmm1",
			"vsqrtps xmm3,xmm2",
			"vsqrtps (rax),xmm2",
			"vsqrtps ymm3,ymm2",
			"vsqrtps (rax),ymm2",
			"vsqrtps xmm3,xmm2{k3}",
			"vsqrtps 0x10(rax),xmm2{k3}",
			"vsqrtps 4(rax){1to4},xmm2{k5}{z}",
			"vsqrtps ymm3,ymm2{k3}",
			"vsqrtps 0x20(rax),ymm2{k3}",
			"vsqrtps 4(rax){1to8},ymm2{k5}{z}",
			"vsqrtps {ru-sae},zmm3,zmm2{k3}{z}",
			"vsqrtps 0x40(rax),zmm2{k3}",
			"vsqrtps 4(rax){1to16},zmm2{k5}{z}",
			"sqrtpd xmm5,xmm1",
			"sqrtpd (rax),xmm1",
			"vsqrtpd xmm3,xmm2",
			"vsqrtpd (rax),xmm2",
			"vsqrtpd ymm3,ymm2",
			"vsqrtpd (rax),ymm2",
			"vsqrtpd xmm3,xmm2{k3}{z}",
			"vsqrtpd 0x10(rax),xmm2{k3}",
			"vsqrtpd 8(rax){1to2},xmm2{k5}{z}",
			"vsqrtpd ymm3,ymm2{k3}{z}",
			"vsqrtpd 0x20(rax),ymm2{k3}",
			"vsqrtpd 8(rax){1to4},ymm2{k5}{z}",
			"vsqrtpd {ru-sae},zmm3,zmm2{k3}{z}",
			"vsqrtpd 0x40(rax),zmm2{k3}",
			"vsqrtpd 8(rax){1to8},zmm2{k5}{z}",
			"sqrtss xmm5,xmm1",
			"sqrtss (rax),xmm1",
			"vsqrtss xmm3,xmm6,xmm2",
			"vsqrtss (rax),xmm6,xmm2",
			"vsqrtss xmm3,xmm6,xmm2{k3}",
			"vsqrtss 4(rax),xmm6,xmm2{k3}",
			"sqrtsd xmm5,xmm1",
			"sqrtsd (rax),xmm1",
			"vsqrtsd xmm3,xmm6,xmm2",
			"vsqrtsd (rax),xmm6,xmm2",
			"vsqrtsd xmm3,xmm6,xmm2{k3}{z}",
			"vsqrtsd 8(rax),xmm6,xmm2{k3}",
			"rsqrtps xmm5,xmm1",
			"rsqrtps (rax),xmm1",
			"vrsqrtps xmm3,xmm2",
			"vrsqrtps (rax),xmm2",
			"vrsqrtps ymm3,ymm2",
			"vrsqrtps (rax),ymm2",
			"rsqrtss xmm5,xmm1",
			"rsqrtss (rax),xmm1",
			"vrsqrtss xmm3,xmm6,xmm2",
			"vrsqrtss (rax),xmm6,xmm2",
			"rcpps xmm5,xmm1",
			"rcpps (rax),xmm1",
			"vrcpps xmm3,xmm2",
			"vrcpps (rax),xmm2",
			"vrcpps ymm3,ymm2",
			"vrcpps (rax),ymm2",
			"rcpss xmm5,xmm1",
			"rcpss (rax),xmm1",
			"vrcpss xmm3,xmm6,xmm2",
			"vrcpss (rax),xmm6,xmm2",
			"andps xmm5,xmm1",
			"andps (rax),xmm1",
			"vandps xmm3,xmm6,xmm2",
			"vandps (rax),xmm6,xmm2",
			"vandps ymm3,ymm6,ymm2",
			"vandps (rax),ymm6,ymm2",
			"vandps xmm3,xmm6,xmm2{k3}",
			"vandps 0x10(rax),xmm6,xmm2{k3}",
			"vandps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vandps ymm3,ymm6,ymm2{k3}",
			"vandps 0x20(rax),ymm6,ymm2{k3}",
			"vandps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vandps zmm3,zmm6,zmm2{k3}",
			"vandps 0x40(rax),zmm6,zmm2{k3}",
			"vandps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"andpd xmm5,xmm1",
			"andpd (rax),xmm1",
			"vandpd xmm3,xmm6,xmm2",
			"vandpd (rax),xmm6,xmm2",
			"vandpd ymm3,ymm6,ymm2",
			"vandpd (rax),ymm6,ymm2",
			"vandpd xmm3,xmm6,xmm2{k3}{z}",
			"vandpd 0x10(rax),xmm6,xmm2{k3}",
			"vandpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vandpd ymm3,ymm6,ymm2{k3}{z}",
			"vandpd 0x20(rax),ymm6,ymm2{k3}",
			"vandpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vandpd zmm3,zmm6,zmm2{k3}{z}",
			"vandpd 0x40(rax),zmm6,zmm2{k3}",
			"vandpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"andnps xmm5,xmm1",
			"andnps (rax),xmm1",
			"vandnps xmm3,xmm6,xmm2",
			"vandnps (rax),xmm6,xmm2",
			"vandnps ymm3,ymm6,ymm2",
			"vandnps (rax),ymm6,ymm2",
			"vandnps xmm3,xmm6,xmm2{k3}",
			"vandnps 0x10(rax),xmm6,xmm2{k3}",
			"vandnps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vandnps ymm3,ymm6,ymm2{k3}",
			"vandnps 0x20(rax),ymm6,ymm2{k3}",
			"vandnps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vandnps zmm3,zmm6,zmm2{k3}",
			"vandnps 0x40(rax),zmm6,zmm2{k3}",
			"vandnps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"andnpd xmm5,xmm1",
			"andnpd (rax),xmm1",
			"vandnpd xmm3,xmm6,xmm2",
			"vandnpd (rax),xmm6,xmm2",
			"vandnpd ymm3,ymm6,ymm2",
			"vandnpd (rax),ymm6,ymm2",
			"vandnpd xmm3,xmm6,xmm2{k3}{z}",
			"vandnpd 0x10(rax),xmm6,xmm2{k3}",
			"vandnpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vandnpd ymm3,ymm6,ymm2{k3}{z}",
			"vandnpd 0x20(rax),ymm6,ymm2{k3}",
			"vandnpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vandnpd zmm3,zmm6,zmm2{k3}{z}",
			"vandnpd 0x40(rax),zmm6,zmm2{k3}",
			"vandnpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"orps xmm5,xmm1",
			"orps (rax),xmm1",
			"vorps xmm3,xmm6,xmm2",
			"vorps (rax),xmm6,xmm2",
			"vorps ymm3,ymm6,ymm2",
			"vorps (rax),ymm6,ymm2",
			"vorps xmm3,xmm6,xmm2{k3}",
			"vorps 0x10(rax),xmm6,xmm2{k3}",
			"vorps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vorps ymm3,ymm6,ymm2{k3}",
			"vorps 0x20(rax),ymm6,ymm2{k3}",
			"vorps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vorps zmm3,zmm6,zmm2{k3}",
			"vorps 0x40(rax),zmm6,zmm2{k3}",
			"vorps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"orpd xmm5,xmm1",
			"orpd (rax),xmm1",
			"vorpd xmm3,xmm6,xmm2",
			"vorpd (rax),xmm6,xmm2",
			"vorpd ymm3,ymm6,ymm2",
			"vorpd (rax),ymm6,ymm2",
			"vorpd xmm3,xmm6,xmm2{k3}{z}",
			"vorpd 0x10(rax),xmm6,xmm2{k3}",
			"vorpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vorpd ymm3,ymm6,ymm2{k3}{z}",
			"vorpd 0x20(rax),ymm6,ymm2{k3}",
			"vorpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vorpd zmm3,zmm6,zmm2{k3}{z}",
			"vorpd 0x40(rax),zmm6,zmm2{k3}",
			"vorpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"xorps xmm5,xmm1",
			"xorps (rax),xmm1",
			"vxorps xmm3,xmm6,xmm2",
			"vxorps (rax),xmm6,xmm2",
			"vxorps ymm3,ymm6,ymm2",
			"vxorps (rax),ymm6,ymm2",
			"vxorps xmm3,xmm6,xmm2{k3}",
			"vxorps 0x10(rax),xmm6,xmm2{k3}",
			"vxorps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vxorps ymm3,ymm6,ymm2{k3}",
			"vxorps 0x20(rax),ymm6,ymm2{k3}",
			"vxorps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vxorps zmm3,zmm6,zmm2{k3}",
			"vxorps 0x40(rax),zmm6,zmm2{k3}",
			"vxorps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"xorpd xmm5,xmm1",
			"xorpd (rax),xmm1",
			"vxorpd xmm3,xmm6,xmm2",
			"vxorpd (rax),xmm6,xmm2",
			"vxorpd ymm3,ymm6,ymm2",
			"vxorpd (rax),ymm6,ymm2",
			"vxorpd xmm3,xmm6,xmm2{k3}{z}",
			"vxorpd 0x10(rax),xmm6,xmm2{k3}",
			"vxorpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vxorpd ymm3,ymm6,ymm2{k3}{z}",
			"vxorpd 0x20(rax),ymm6,ymm2{k3}",
			"vxorpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vxorpd zmm3,zmm6,zmm2{k3}{z}",
			"vxorpd 0x40(rax),zmm6,zmm2{k3}",
			"vxorpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"addps xmm5,xmm1",
			"addps (rax),xmm1",
			"vaddps xmm3,xmm6,xmm2",
			"vaddps (rax),xmm6,xmm2",
			"vaddps ymm3,ymm6,ymm2",
			"vaddps (rax),ymm6,ymm2",
			"vaddps xmm3,xmm6,xmm2{k3}",
			"vaddps 0x10(rax),xmm6,xmm2{k3}",
			"vaddps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vaddps ymm3,ymm6,ymm2{k3}",
			"vaddps 0x20(rax),ymm6,ymm2{k3}",
			"vaddps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vaddps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vaddps 0x40(rax),zmm6,zmm2{k3}",
			"vaddps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"addpd xmm5,xmm1",
			"addpd (rax),xmm1",
			"vaddpd xmm3,xmm6,xmm2",
			"vaddpd (rax),xmm6,xmm2",
			"vaddpd ymm3,ymm6,ymm2",
			"vaddpd (rax),ymm6,ymm2",
			"vaddpd xmm3,xmm6,xmm2{k3}{z}",
			"vaddpd 0x10(rax),xmm6,xmm2{k3}",
			"vaddpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vaddpd ymm3,ymm6,ymm2{k3}{z}",
			"vaddpd 0x20(rax),ymm6,ymm2{k3}",
			"vaddpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vaddpd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vaddpd 0x40(rax),zmm6,zmm2{k3}",
			"vaddpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"addss xmm5,xmm1",
			"addss (rax),xmm1",
			"vaddss xmm3,xmm6,xmm2",
			"vaddss (rax),xmm6,xmm2",
			"vaddss xmm3,xmm6,xmm2{k3}",
			"vaddss 4(rax),xmm6,xmm2{k3}",
			"addsd xmm5,xmm1",
			"addsd (rax),xmm1",
			"vaddsd xmm3,xmm6,xmm2",
			"vaddsd (rax),xmm6,xmm2",
			"vaddsd xmm3,xmm6,xmm2{k3}{z}",
			"vaddsd 8(rax),xmm6,xmm2{k3}",
			"mulps xmm5,xmm1",
			"mulps (rax),xmm1",
			"vmulps xmm3,xmm6,xmm2",
			"vmulps (rax),xmm6,xmm2",
			"vmulps ymm3,ymm6,ymm2",
			"vmulps (rax),ymm6,ymm2",
			"vmulps xmm3,xmm6,xmm2{k3}",
			"vmulps 0x10(rax),xmm6,xmm2{k3}",
			"vmulps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vmulps ymm3,ymm6,ymm2{k3}",
			"vmulps 0x20(rax),ymm6,ymm2{k3}",
			"vmulps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vmulps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vmulps 0x40(rax),zmm6,zmm2{k3}",
			"vmulps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"mulpd xmm5,xmm1",
			"mulpd (rax),xmm1",
			"vmulpd xmm3,xmm6,xmm2",
			"vmulpd (rax),xmm6,xmm2",
			"vmulpd ymm3,ymm6,ymm2",
			"vmulpd (rax),ymm6,ymm2",
			"vmulpd xmm3,xmm6,xmm2{k3}{z}",
			"vmulpd 0x10(rax),xmm6,xmm2{k3}",
			"vmulpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vmulpd ymm3,ymm6,ymm2{k3}{z}",
			"vmulpd 0x20(rax),ymm6,ymm2{k3}",
			"vmulpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vmulpd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vmulpd 0x40(rax),zmm6,zmm2{k3}",
			"vmulpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"mulss xmm5,xmm1",
			"mulss (rax),xmm1",
			"vmulss xmm3,xmm6,xmm2",
			"vmulss (rax),xmm6,xmm2",
			"vmulss xmm3,xmm6,xmm2{k3}",
			"vmulss 4(rax),xmm6,xmm2{k3}",
			"mulsd xmm5,xmm1",
			"mulsd (rax),xmm1",
			"vmulsd xmm3,xmm6,xmm2",
			"vmulsd (rax),xmm6,xmm2",
			"vmulsd xmm3,xmm6,xmm2{k3}{z}",
			"vmulsd 8(rax),xmm6,xmm2{k3}",
			"cvtps2pd xmm5,xmm1",
			"cvtps2pd (rax),xmm1",
			"vcvtps2pd xmm5,xmm1",
			"vcvtps2pd (rax),xmm2",
			"vcvtps2pd xmm5,ymm1",
			"vcvtps2pd (rax),ymm2",
			"vcvtps2pd xmm3,xmm2{k3}",
			"vcvtps2pd 8(rax),xmm2",
			"vcvtps2pd 4(rax){1to2},xmm2{k3}{z}",
			"vcvtps2pd xmm3,ymm2{k3}",
			"vcvtps2pd 0x10(rax),ymm2",
			"vcvtps2pd 4(rax){1to4},ymm2{k3}{z}",
			"vcvtps2pd ymm3,zmm2{k3}",
			"vcvtps2pd 0x20(rax),zmm2",
			"vcvtps2pd 4(rax){1to8},zmm2{k3}{z}",
			"cvtpd2ps xmm5,xmm1",
			"cvtpd2ps (rax),xmm1",
			"vcvtpd2psx xmm5,xmm1",
			"vcvtpd2psx (rax),xmm2",
			"vcvtpd2psy ymm5,xmm1",
			"vcvtpd2psy (rax),xmm2",
		};
	}
}
#endif
