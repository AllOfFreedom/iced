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
	public sealed class GasFormatterTest64_ForceSuffix_004 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_ForceSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_004.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_004.AllInfos_Length] {
			"vpsllw 0x10(rax),ymm6,ymm2{k3}",
			"vpsllw xmm3,zmm6,zmm2{k3}",
			"vpsllw 0x10(rax),zmm6,zmm2{k3}",
			"pslld mm5,mm1",
			"pslld (rax),mm1",
			"pslld xmm5,xmm1",
			"pslld (rax),xmm1",
			"vpslld xmm3,xmm6,xmm2",
			"vpslld (rax),xmm6,xmm2",
			"vpslld xmm3,ymm6,ymm2",
			"vpslld (rax),ymm6,ymm2",
			"vpslld xmm3,xmm6,xmm2{k3}",
			"vpslld 0x10(rax),xmm6,xmm2{k3}",
			"vpslld xmm3,ymm6,ymm2{k3}",
			"vpslld 0x10(rax),ymm6,ymm2{k3}",
			"vpslld xmm3,zmm6,zmm2{k3}",
			"vpslld 0x10(rax),zmm6,zmm2{k3}",
			"psllq mm5,mm1",
			"psllq (rax),mm1",
			"psllq xmm5,xmm1",
			"psllq (rax),xmm1",
			"vpsllq xmm3,xmm6,xmm2",
			"vpsllq (rax),xmm6,xmm2",
			"vpsllq xmm3,ymm6,ymm2",
			"vpsllq (rax),ymm6,ymm2",
			"vpsllq xmm3,xmm6,xmm2{k3}",
			"vpsllq 0x10(rax),xmm6,xmm2{k3}",
			"vpsllq xmm3,ymm6,ymm2{k3}",
			"vpsllq 0x10(rax),ymm6,ymm2{k3}",
			"vpsllq xmm3,zmm6,zmm2{k3}",
			"vpsllq 0x10(rax),zmm6,zmm2{k3}",
			"pmuludq mm5,mm1",
			"pmuludq (rax),mm1",
			"pmuludq xmm5,xmm1",
			"pmuludq (rax),xmm1",
			"vpmuludq xmm3,xmm6,xmm2",
			"vpmuludq (rax),xmm6,xmm2",
			"vpmuludq ymm3,ymm6,ymm2",
			"vpmuludq (rax),ymm6,ymm2",
			"vpmuludq xmm3,xmm6,xmm2{k3}{z}",
			"vpmuludq 0x10(rax),xmm6,xmm2{k3}",
			"vpmuludq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpmuludq ymm3,ymm6,ymm2{k3}{z}",
			"vpmuludq 0x20(rax),ymm6,ymm2{k3}",
			"vpmuludq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpmuludq zmm3,zmm6,zmm2{k3}{z}",
			"vpmuludq 0x40(rax),zmm6,zmm2{k3}",
			"vpmuludq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"pmaddwd mm5,mm1",
			"pmaddwd (rax),mm1",
			"pmaddwd xmm5,xmm1",
			"pmaddwd (rax),xmm1",
			"vpmaddwd xmm3,xmm6,xmm2",
			"vpmaddwd (rax),xmm6,xmm2",
			"vpmaddwd ymm3,ymm6,ymm2",
			"vpmaddwd (rax),ymm6,ymm2",
			"vpmaddwd xmm3,xmm6,xmm2{k3}",
			"vpmaddwd 0x10(rax),xmm6,xmm2{k3}",
			"vpmaddwd ymm3,ymm6,ymm2{k3}",
			"vpmaddwd 0x20(rax),ymm6,ymm2{k3}",
			"vpmaddwd zmm3,zmm6,zmm2{k3}",
			"vpmaddwd 0x40(rax),zmm6,zmm2{k3}",
			"psadbw mm5,mm1",
			"psadbw (rax),mm1",
			"psadbw xmm5,xmm1",
			"psadbw (rax),xmm1",
			"vpsadbw xmm3,xmm6,xmm2",
			"vpsadbw (rax),xmm6,xmm2",
			"vpsadbw ymm3,ymm6,ymm2",
			"vpsadbw (rax),ymm6,ymm2",
			"vpsadbw xmm3,xmm6,xmm2",
			"vpsadbw 0x10(rax),xmm6,xmm2",
			"vpsadbw ymm3,ymm6,ymm2",
			"vpsadbw 0x20(rax),ymm6,ymm2",
			"vpsadbw zmm3,zmm6,zmm2",
			"vpsadbw 0x40(rax),zmm6,zmm2",
			"addr32 maskmovq mm3,mm2",
			"maskmovq mm3,mm2",
			"addr32 maskmovdqu xmm3,xmm2",
			"maskmovdqu xmm3,xmm2",
			"addr32 vmaskmovdqu xmm3,xmm2",
			"vmaskmovdqu xmm3,xmm2",
			"psubb mm5,mm1",
			"psubb (rax),mm1",
			"psubb xmm5,xmm1",
			"psubb (rax),xmm1",
			"vpsubb xmm3,xmm6,xmm2",
			"vpsubb (rax),xmm6,xmm2",
			"vpsubb ymm3,ymm6,ymm2",
			"vpsubb (rax),ymm6,ymm2",
			"vpsubb xmm3,xmm6,xmm2{k3}",
			"vpsubb 0x10(rax),xmm6,xmm2{k3}",
			"vpsubb ymm3,ymm6,ymm2{k3}",
			"vpsubb 0x20(rax),ymm6,ymm2{k3}",
			"vpsubb zmm3,zmm6,zmm2{k3}",
			"vpsubb 0x40(rax),zmm6,zmm2{k3}",
			"psubw mm5,mm1",
			"psubw (rax),mm1",
			"psubw xmm5,xmm1",
			"psubw (rax),xmm1",
			"vpsubw xmm3,xmm6,xmm2",
			"vpsubw (rax),xmm6,xmm2",
			"vpsubw ymm3,ymm6,ymm2",
			"vpsubw (rax),ymm6,ymm2",
			"vpsubw xmm3,xmm6,xmm2{k3}",
			"vpsubw 0x10(rax),xmm6,xmm2{k3}",
			"vpsubw ymm3,ymm6,ymm2{k3}",
			"vpsubw 0x20(rax),ymm6,ymm2{k3}",
			"vpsubw zmm3,zmm6,zmm2{k3}",
			"vpsubw 0x40(rax),zmm6,zmm2{k3}",
			"psubd mm5,mm1",
			"psubd (rax),mm1",
			"psubd xmm5,xmm1",
			"psubd (rax),xmm1",
			"vpsubd xmm3,xmm6,xmm2",
			"vpsubd (rax),xmm6,xmm2",
			"vpsubd ymm3,ymm6,ymm2",
			"vpsubd (rax),ymm6,ymm2",
			"vpsubd xmm3,xmm6,xmm2{k3}{z}",
			"vpsubd 0x10(rax),xmm6,xmm2{k3}",
			"vpsubd 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpsubd ymm3,ymm6,ymm2{k3}{z}",
			"vpsubd 0x20(rax),ymm6,ymm2{k3}",
			"vpsubd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpsubd zmm3,zmm6,zmm2{k3}{z}",
			"vpsubd 0x40(rax),zmm6,zmm2{k3}",
			"vpsubd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"psubq mm5,mm1",
			"psubq (rax),mm1",
			"psubq xmm5,xmm1",
			"psubq (rax),xmm1",
			"vpsubq xmm3,xmm6,xmm2",
			"vpsubq (rax),xmm6,xmm2",
			"vpsubq ymm3,ymm6,ymm2",
			"vpsubq (rax),ymm6,ymm2",
			"vpsubq xmm3,xmm6,xmm2{k3}{z}",
			"vpsubq 0x10(rax),xmm6,xmm2{k3}",
			"vpsubq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpsubq ymm3,ymm6,ymm2{k3}{z}",
			"vpsubq 0x20(rax),ymm6,ymm2{k3}",
			"vpsubq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpsubq zmm3,zmm6,zmm2{k3}{z}",
			"vpsubq 0x40(rax),zmm6,zmm2{k3}",
			"vpsubq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"paddb mm5,mm1",
			"paddb (rax),mm1",
			"paddb xmm5,xmm1",
			"paddb (rax),xmm1",
			"vpaddb xmm3,xmm6,xmm2",
			"vpaddb (rax),xmm6,xmm2",
			"vpaddb ymm3,ymm6,ymm2",
			"vpaddb (rax),ymm6,ymm2",
			"vpaddb xmm3,xmm6,xmm2{k3}",
			"vpaddb 0x10(rax),xmm6,xmm2{k3}",
			"vpaddb ymm3,ymm6,ymm2{k3}",
			"vpaddb 0x20(rax),ymm6,ymm2{k3}",
			"vpaddb zmm3,zmm6,zmm2{k3}",
			"vpaddb 0x40(rax),zmm6,zmm2{k3}",
			"paddw mm5,mm1",
			"paddw (rax),mm1",
			"paddw xmm5,xmm1",
			"paddw (rax),xmm1",
			"vpaddw xmm3,xmm6,xmm2",
			"vpaddw (rax),xmm6,xmm2",
			"vpaddw ymm3,ymm6,ymm2",
			"vpaddw (rax),ymm6,ymm2",
			"vpaddw xmm3,xmm6,xmm2{k3}",
			"vpaddw 0x10(rax),xmm6,xmm2{k3}",
			"vpaddw ymm3,ymm6,ymm2{k3}",
			"vpaddw 0x20(rax),ymm6,ymm2{k3}",
			"vpaddw zmm3,zmm6,zmm2{k3}",
			"vpaddw 0x40(rax),zmm6,zmm2{k3}",
			"paddd mm5,mm1",
			"paddd (rax),mm1",
			"paddd xmm5,xmm1",
			"paddd (rax),xmm1",
			"vpaddd xmm3,xmm6,xmm2",
			"vpaddd (rax),xmm6,xmm2",
			"vpaddd ymm3,ymm6,ymm2",
			"vpaddd (rax),ymm6,ymm2",
			"vpaddd xmm3,xmm6,xmm2{k3}{z}",
			"vpaddd 0x10(rax),xmm6,xmm2{k3}",
			"vpaddd 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpaddd ymm3,ymm6,ymm2{k3}{z}",
			"vpaddd 0x20(rax),ymm6,ymm2{k3}",
			"vpaddd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpaddd zmm3,zmm6,zmm2{k3}{z}",
			"vpaddd 0x40(rax),zmm6,zmm2{k3}",
			"vpaddd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"ud0w si,cx",
			"ud0w (rax),bx",
			"ud0l esi,ecx",
			"ud0l (rax),ebx",
			"ud0q rsi,rcx",
			"ud0q (rax),rbx",
			"pshufb mm5,mm1",
			"pshufb (rax),mm1",
			"pshufb xmm5,xmm1",
			"pshufb (rax),xmm1",
			"vpshufb xmm3,xmm6,xmm2",
			"vpshufb (rax),xmm6,xmm2",
			"vpshufb ymm3,ymm6,ymm2",
			"vpshufb (rax),ymm6,ymm2",
			"vpshufb xmm3,xmm6,xmm2{k3}",
			"vpshufb 0x10(rax),xmm6,xmm2{k3}",
			"vpshufb ymm3,ymm6,ymm2{k3}",
			"vpshufb 0x20(rax),ymm6,ymm2{k3}",
			"vpshufb zmm3,zmm6,zmm2{k3}",
			"vpshufb 0x40(rax),zmm6,zmm2{k3}",
			"phaddw mm5,mm1",
			"phaddw (rax),mm1",
			"phaddw xmm5,xmm1",
			"phaddw (rax),xmm1",
			"vphaddw xmm3,xmm6,xmm2",
			"vphaddw (rax),xmm6,xmm2",
			"vphaddw ymm3,ymm6,ymm2",
			"vphaddw (rax),ymm6,ymm2",
			"phaddd mm5,mm1",
			"phaddd (rax),mm1",
			"phaddd xmm5,xmm1",
			"phaddd (rax),xmm1",
			"vphaddd xmm3,xmm6,xmm2",
			"vphaddd (rax),xmm6,xmm2",
			"vphaddd ymm3,ymm6,ymm2",
			"vphaddd (rax),ymm6,ymm2",
			"phaddsw mm5,mm1",
			"phaddsw (rax),mm1",
			"phaddsw xmm5,xmm1",
			"phaddsw (rax),xmm1",
			"vphaddsw xmm3,xmm6,xmm2",
			"vphaddsw (rax),xmm6,xmm2",
			"vphaddsw ymm3,ymm6,ymm2",
			"vphaddsw (rax),ymm6,ymm2",
			"pmaddubsw mm5,mm1",
			"pmaddubsw (rax),mm1",
			"pmaddubsw xmm5,xmm1",
			"pmaddubsw (rax),xmm1",
			"vpmaddubsw xmm3,xmm6,xmm2",
			"vpmaddubsw (rax),xmm6,xmm2",
			"vpmaddubsw ymm3,ymm6,ymm2",
			"vpmaddubsw (rax),ymm6,ymm2",
			"vpmaddubsw xmm3,xmm6,xmm2{k3}",
			"vpmaddubsw 0x10(rax),xmm6,xmm2{k3}",
			"vpmaddubsw ymm3,ymm6,ymm2{k3}",
			"vpmaddubsw 0x20(rax),ymm6,ymm2{k3}",
			"vpmaddubsw zmm3,zmm6,zmm2{k3}",
			"vpmaddubsw 0x40(rax),zmm6,zmm2{k3}",
			"phsubw mm5,mm1",
			"phsubw (rax),mm1",
			"phsubw xmm5,xmm1",
			"phsubw (rax),xmm1",
			"vphsubw xmm3,xmm6,xmm2",
			"vphsubw (rax),xmm6,xmm2",
			"vphsubw ymm3,ymm6,ymm2",
			"vphsubw (rax),ymm6,ymm2",
			"phsubd mm5,mm1",
			"phsubd (rax),mm1",
			"phsubd xmm5,xmm1",
			"phsubd (rax),xmm1",
			"vphsubd xmm3,xmm6,xmm2",
			"vphsubd (rax),xmm6,xmm2",
			"vphsubd ymm3,ymm6,ymm2",
			"vphsubd (rax),ymm6,ymm2",
			"phsubsw mm5,mm1",
			"phsubsw (rax),mm1",
			"phsubsw xmm5,xmm1",
			"phsubsw (rax),xmm1",
			"vphsubsw xmm3,xmm6,xmm2",
			"vphsubsw (rax),xmm6,xmm2",
			"vphsubsw ymm3,ymm6,ymm2",
			"vphsubsw (rax),ymm6,ymm2",
			"psignb mm5,mm1",
			"psignb (rax),mm1",
			"psignb xmm5,xmm1",
			"psignb (rax),xmm1",
			"vpsignb xmm3,xmm6,xmm2",
			"vpsignb (rax),xmm6,xmm2",
			"vpsignb ymm3,ymm6,ymm2",
			"vpsignb (rax),ymm6,ymm2",
			"psignw mm5,mm1",
			"psignw (rax),mm1",
			"psignw xmm5,xmm1",
			"psignw (rax),xmm1",
			"vpsignw xmm3,xmm6,xmm2",
			"vpsignw (rax),xmm6,xmm2",
			"vpsignw ymm3,ymm6,ymm2",
			"vpsignw (rax),ymm6,ymm2",
			"psignd mm5,mm1",
			"psignd (rax),mm1",
			"psignd xmm5,xmm1",
			"psignd (rax),xmm1",
			"vpsignd xmm3,xmm6,xmm2",
			"vpsignd (rax),xmm6,xmm2",
			"vpsignd ymm3,ymm6,ymm2",
			"vpsignd (rax),ymm6,ymm2",
			"pmulhrsw mm5,mm1",
			"pmulhrsw (rax),mm1",
			"pmulhrsw xmm5,xmm1",
			"pmulhrsw (rax),xmm1",
			"vpmulhrsw xmm3,xmm6,xmm2",
			"vpmulhrsw (rax),xmm6,xmm2",
			"vpmulhrsw ymm3,ymm6,ymm2",
			"vpmulhrsw (rax),ymm6,ymm2",
			"vpmulhrsw xmm3,xmm6,xmm2{k3}",
			"vpmulhrsw 0x10(rax),xmm6,xmm2{k3}",
			"vpmulhrsw ymm3,ymm6,ymm2{k3}",
			"vpmulhrsw 0x20(rax),ymm6,ymm2{k3}",
			"vpmulhrsw zmm3,zmm6,zmm2{k3}",
			"vpmulhrsw 0x40(rax),zmm6,zmm2{k3}",
			"vpermilps xmm3,xmm6,xmm2",
			"vpermilps (rax),xmm6,xmm2",
			"vpermilps ymm3,ymm6,ymm2",
			"vpermilps (rax),ymm6,ymm2",
			"vpermilps xmm3,xmm6,xmm2{k3}{z}",
			"vpermilps 0x10(rax),xmm6,xmm2{k3}",
			"vpermilps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpermilps ymm3,ymm6,ymm2{k3}{z}",
			"vpermilps 0x20(rax),ymm6,ymm2{k3}",
			"vpermilps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpermilps zmm3,zmm6,zmm2{k3}{z}",
			"vpermilps 0x40(rax),zmm6,zmm2{k3}",
			"vpermilps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpermilpd xmm3,xmm6,xmm2",
			"vpermilpd (rax),xmm6,xmm2",
			"vpermilpd ymm3,ymm6,ymm2",
			"vpermilpd (rax),ymm6,ymm2",
			"vpermilpd xmm3,xmm6,xmm2{k3}{z}",
			"vpermilpd 0x10(rax),xmm6,xmm2{k3}",
			"vpermilpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpermilpd ymm3,ymm6,ymm2{k3}{z}",
			"vpermilpd 0x20(rax),ymm6,ymm2{k3}",
			"vpermilpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpermilpd zmm3,zmm6,zmm2{k3}{z}",
			"vpermilpd 0x40(rax),zmm6,zmm2{k3}",
			"vpermilpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vtestps xmm5,xmm1",
			"vtestps (rax),xmm2",
			"vtestps ymm5,ymm1",
			"vtestps (rax),ymm2",
			"vtestpd xmm5,xmm1",
			"vtestpd (rax),xmm2",
			"vtestpd ymm5,ymm1",
			"vtestpd (rax),ymm2",
			"pblendvb xmm0,xmm5,xmm1",
			"pblendvb xmm0,(rax),xmm1",
			"vpsrlvw xmm3,xmm6,xmm2{k3}",
			"vpsrlvw 0x10(rax),xmm6,xmm2{k3}",
			"vpsrlvw ymm3,ymm6,ymm2{k3}",
			"vpsrlvw 0x20(rax),ymm6,ymm2{k3}",
			"vpsrlvw zmm3,zmm6,zmm2{k3}",
			"vpsrlvw 0x40(rax),zmm6,zmm2{k3}",
			"vpmovuswb xmm2,xmm3{k3}",
			"vpmovuswb xmm2,8(rax){k3}",
			"vpmovuswb ymm2,xmm3{k3}",
			"vpmovuswb ymm2,0x10(rax){k3}",
			"vpmovuswb zmm2,ymm3{k3}",
			"vpmovuswb zmm2,0x20(rax){k3}",
			"vpsravw xmm3,xmm6,xmm2{k3}",
			"vpsravw 0x10(rax),xmm6,xmm2{k3}",
			"vpsravw ymm3,ymm6,ymm2{k3}",
			"vpsravw 0x20(rax),ymm6,ymm2{k3}",
			"vpsravw zmm3,zmm6,zmm2{k3}",
			"vpsravw 0x40(rax),zmm6,zmm2{k3}",
			"vpmovusdb xmm2,xmm3{k3}",
			"vpmovusdb xmm2,4(rax){k3}",
			"vpmovusdb ymm2,xmm3{k3}",
			"vpmovusdb ymm2,8(rax){k3}",
			"vpmovusdb zmm2,xmm3{k3}",
			"vpmovusdb zmm2,0x10(rax){k3}",
			"vpsllvw xmm3,xmm6,xmm2{k3}",
			"vpsllvw 0x10(rax),xmm6,xmm2{k3}",
			"vpsllvw ymm3,ymm6,ymm2{k3}",
			"vpsllvw 0x20(rax),ymm6,ymm2{k3}",
			"vpsllvw zmm3,zmm6,zmm2{k3}",
			"vpsllvw 0x40(rax),zmm6,zmm2{k3}",
			"vpmovusqb xmm2,xmm3{k3}",
			"vpmovusqb xmm2,2(rax){k3}",
			"vpmovusqb ymm2,xmm3{k3}",
			"vpmovusqb ymm2,4(rax){k3}",
			"vpmovusqb zmm2,xmm3{k3}",
			"vpmovusqb zmm2,8(rax){k3}",
			"vcvtph2ps xmm5,xmm1",
			"vcvtph2ps (rax),xmm2",
			"vcvtph2ps xmm5,ymm1",
			"vcvtph2ps (rax),ymm2",
			"vcvtph2ps xmm3,xmm2{k3}{z}",
			"vcvtph2ps 8(rax),xmm2{k3}",
			"vcvtph2ps xmm3,ymm2{k3}{z}",
			"vcvtph2ps 0x10(rax),ymm2{k3}",
			"vcvtph2ps {sae},ymm3,zmm2{k3}{z}",
			"vcvtph2ps 0x20(rax),zmm2{k3}",
			"vpmovusdw xmm2,xmm3{k3}",
			"vpmovusdw xmm2,8(rax){k3}",
			"vpmovusdw ymm2,xmm3{k3}",
			"vpmovusdw ymm2,0x10(rax){k3}",
			"vpmovusdw zmm2,ymm3{k3}",
			"vpmovusdw zmm2,0x20(rax){k3}",
			"blendvps xmm0,xmm5,xmm1",
			"blendvps xmm0,(rax),xmm1",
			"vprorvd xmm3,xmm6,xmm2{k3}{z}",
			"vprorvd 0x10(rax),xmm6,xmm2{k3}",
			"vprorvd 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vprorvd ymm3,ymm6,ymm2{k3}{z}",
			"vprorvd 0x20(rax),ymm6,ymm2{k3}",
			"vprorvd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vprorvd zmm3,zmm6,zmm2{k3}{z}",
			"vprorvd 0x40(rax),zmm6,zmm2{k3}",
			"vprorvd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vprorvq xmm3,xmm6,xmm2{k3}{z}",
			"vprorvq 0x10(rax),xmm6,xmm2{k3}",
			"vprorvq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vprorvq ymm3,ymm6,ymm2{k3}{z}",
			"vprorvq 0x20(rax),ymm6,ymm2{k3}",
			"vprorvq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vprorvq zmm3,zmm6,zmm2{k3}{z}",
			"vprorvq 0x40(rax),zmm6,zmm2{k3}",
			"vprorvq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpmovusqw xmm2,xmm3{k3}",
			"vpmovusqw xmm2,4(rax){k3}",
			"vpmovusqw ymm2,xmm3{k3}",
			"vpmovusqw ymm2,8(rax){k3}",
			"vpmovusqw zmm2,xmm3{k3}",
			"vpmovusqw zmm2,0x10(rax){k3}",
			"blendvpd xmm0,xmm5,xmm1",
			"blendvpd xmm0,(rax),xmm1",
			"vprolvd xmm3,xmm6,xmm2{k3}{z}",
			"vprolvd 0x10(rax),xmm6,xmm2{k3}",
			"vprolvd 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vprolvd ymm3,ymm6,ymm2{k3}{z}",
			"vprolvd 0x20(rax),ymm6,ymm2{k3}",
			"vprolvd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vprolvd zmm3,zmm6,zmm2{k3}{z}",
			"vprolvd 0x40(rax),zmm6,zmm2{k3}",
			"vprolvd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vprolvq xmm3,xmm6,xmm2{k3}{z}",
			"vprolvq 0x10(rax),xmm6,xmm2{k3}",
			"vprolvq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vprolvq ymm3,ymm6,ymm2{k3}{z}",
			"vprolvq 0x20(rax),ymm6,ymm2{k3}",
			"vprolvq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vprolvq zmm3,zmm6,zmm2{k3}{z}",
			"vprolvq 0x40(rax),zmm6,zmm2{k3}",
			"vprolvq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpmovusqd xmm2,xmm3{k3}",
			"vpmovusqd xmm2,8(rax){k3}",
			"vpmovusqd ymm2,xmm3{k3}",
			"vpmovusqd ymm2,0x10(rax){k3}",
			"vpmovusqd zmm2,ymm3{k3}",
			"vpmovusqd zmm2,0x20(rax){k3}",
			"vpermps ymm3,ymm6,ymm2",
			"vpermps (rax),ymm6,ymm2",
			"vpermps ymm3,ymm6,ymm2{k3}{z}",
			"vpermps 0x20(rax),ymm6,ymm2{k3}",
			"vpermps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpermps zmm3,zmm6,zmm2{k3}{z}",
			"vpermps 0x40(rax),zmm6,zmm2{k3}",
			"vpermps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpermpd ymm3,ymm6,ymm2{k3}{z}",
			"vpermpd 0x20(rax),ymm6,ymm2{k3}",
			"vpermpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpermpd zmm3,zmm6,zmm2{k3}{z}",
			"vpermpd 0x40(rax),zmm6,zmm2{k3}",
			"vpermpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"ptest xmm5,xmm1",
			"ptest (rax),xmm1",
			"vptest xmm5,xmm1",
			"vptest (rax),xmm2",
			"vptest ymm5,ymm1",
			"vptest (rax),ymm2",
			"vbroadcastss xmm5,xmm1",
			"vbroadcastss (rax),xmm2",
			"vbroadcastss xmm5,ymm1",
			"vbroadcastss (rax),ymm2",
			"vbroadcastss xmm3,xmm2",
			"vbroadcastss 4(rax),xmm2",
			"vbroadcastss xmm3,ymm2",
			"vbroadcastss 4(rax),ymm2",
			"vbroadcastss xmm3,zmm2",
			"vbroadcastss 4(rax),zmm2",
			"vbroadcastsd xmm5,ymm1",
			"vbroadcastsd (rax),ymm2",
			"vbroadcastf32x2 xmm3,ymm2",
			"vbroadcastf32x2 8(rax),ymm2",
			"vbroadcastf32x2 xmm3,zmm2",
			"vbroadcastf32x2 8(rax),zmm2",
			"vbroadcastsd xmm3,ymm2",
			"vbroadcastsd 8(rax),ymm2",
			"vbroadcastsd xmm3,zmm2",
			"vbroadcastsd 8(rax),zmm2",
			"vbroadcastf128 (rax),ymm2",
			"vbroadcastf32x4 0x10(rax),ymm2",
			"vbroadcastf32x4 0x10(rax),zmm2",
			"vbroadcastf64x2 0x10(rax),ymm2",
			"vbroadcastf64x2 0x10(rax),zmm2",
			"vbroadcastf32x8 0x20(rax),zmm2",
			"vbroadcastf64x4 0x20(rax),zmm2",
			"pabsb mm5,mm1",
			"pabsb (rax),mm1",
			"pabsb xmm5,xmm1",
			"pabsb (rax),xmm1",
			"vpabsb xmm5,xmm1",
			"vpabsb (rax),xmm2",
			"vpabsb ymm5,ymm1",
			"vpabsb (rax),ymm2",
			"vpabsb xmm3,xmm2",
			"vpabsb 0x10(rax),xmm2",
			"vpabsb ymm3,ymm2",
			"vpabsb 0x20(rax),ymm2",
			"vpabsb zmm3,zmm2",
			"vpabsb 0x40(rax),zmm2",
			"pabsw mm5,mm1",
			"pabsw (rax),mm1",
			"pabsw xmm5,xmm1",
			"pabsw (rax),xmm1",
			"vpabsw xmm5,xmm1",
			"vpabsw (rax),xmm2",
			"vpabsw ymm5,ymm1",
			"vpabsw (rax),ymm2",
			"vpabsw xmm3,xmm2",
			"vpabsw 0x10(rax),xmm2",
			"vpabsw ymm3,ymm2",
			"vpabsw 0x20(rax),ymm2",
			"vpabsw zmm3,zmm2",
			"vpabsw 0x40(rax),zmm2",
			"pabsd mm5,mm1",
			"pabsd (rax),mm1",
			"pabsd xmm5,xmm1",
			"pabsd (rax),xmm1",
			"vpabsd xmm3,xmm2",
			"vpabsd (rax),xmm2",
			"vpabsd ymm3,ymm2",
			"vpabsd (rax),ymm2",
			"vpabsd xmm3,xmm2{k3}{z}",
			"vpabsd 0x10(rax),xmm2{k3}",
			"vpabsd 4(rax){1to4},xmm2{k5}{z}",
			"vpabsd ymm3,ymm2{k3}{z}",
			"vpabsd 0x20(rax),ymm2{k3}",
			"vpabsd 4(rax){1to8},ymm2{k5}{z}",
			"vpabsd zmm3,zmm2{k3}{z}",
			"vpabsd 0x40(rax),zmm2{k3}",
			"vpabsd 4(rax){1to16},zmm2{k5}{z}",
			"vpabsq xmm3,xmm2{k3}{z}",
			"vpabsq 0x10(rax),xmm2{k3}",
			"vpabsq 8(rax){1to2},xmm2{k5}{z}",
			"vpabsq ymm3,ymm2{k3}{z}",
			"vpabsq 0x20(rax),ymm2{k3}",
			"vpabsq 8(rax){1to4},ymm2{k5}{z}",
			"vpabsq zmm3,zmm2{k3}{z}",
			"vpabsq 0x40(rax),zmm2{k3}",
			"vpabsq 8(rax){1to8},zmm2{k5}{z}",
			"pmovsxbw xmm5,xmm1",
			"pmovsxbw (rax),xmm1",
			"vpmovsxbw xmm5,xmm1",
			"vpmovsxbw (rax),xmm2",
			"vpmovsxbw xmm5,ymm1",
			"vpmovsxbw (rax),ymm2",
			"vpmovsxbw xmm3,xmm2",
			"vpmovsxbw 8(rax),xmm2",
			"vpmovsxbw xmm3,ymm2",
			"vpmovsxbw 0x10(rax),ymm2",
			"vpmovsxbw ymm3,zmm2",
			"vpmovsxbw 0x20(rax),zmm2",
			"vpmovswb xmm2,xmm3{k3}",
			"vpmovswb xmm2,8(rax){k3}",
			"vpmovswb ymm2,xmm3{k3}",
			"vpmovswb ymm2,0x10(rax){k3}",
			"vpmovswb zmm2,ymm3{k3}",
			"vpmovswb zmm2,0x20(rax){k3}",
			"pmovsxbd xmm5,xmm1",
			"pmovsxbd (rax),xmm1",
			"vpmovsxbd xmm5,xmm1",
			"vpmovsxbd (rax),xmm2",
			"vpmovsxbd xmm5,ymm1",
			"vpmovsxbd (rax),ymm2",
			"vpmovsxbd xmm3,xmm2",
			"vpmovsxbd 4(rax),xmm2",
			"vpmovsxbd xmm3,ymm2",
			"vpmovsxbd 8(rax),ymm2",
			"vpmovsxbd xmm3,zmm2",
			"vpmovsxbd 0x10(rax),zmm2",
			"vpmovsdb xmm2,xmm3{k3}",
			"vpmovsdb xmm2,4(rax){k3}",
			"vpmovsdb ymm2,xmm3{k3}",
			"vpmovsdb ymm2,8(rax){k3}",
			"vpmovsdb zmm2,xmm3{k3}",
			"vpmovsdb zmm2,0x10(rax){k3}",
			"pmovsxbq xmm5,xmm1",
			"pmovsxbq (rax),xmm1",
			"vpmovsxbq xmm5,xmm1",
			"vpmovsxbq (rax),xmm2",
			"vpmovsxbq xmm5,ymm1",
			"vpmovsxbq (rax),ymm2",
			"vpmovsxbq xmm3,xmm2",
			"vpmovsxbq 2(rax),xmm2",
			"vpmovsxbq xmm3,ymm2",
			"vpmovsxbq 4(rax),ymm2",
			"vpmovsxbq xmm3,zmm2",
			"vpmovsxbq 8(rax),zmm2",
			"vpmovsqb xmm2,xmm3{k3}",
			"vpmovsqb xmm2,2(rax){k3}",
			"vpmovsqb ymm2,xmm3{k3}",
			"vpmovsqb ymm2,4(rax){k3}",
			"vpmovsqb zmm2,xmm3{k3}",
			"vpmovsqb zmm2,8(rax){k3}",
			"pmovsxwd xmm5,xmm1",
			"pmovsxwd (rax),xmm1",
			"vpmovsxwd xmm5,xmm1",
			"vpmovsxwd (rax),xmm2",
			"vpmovsxwd xmm5,ymm1",
			"vpmovsxwd (rax),ymm2",
			"vpmovsxwd xmm3,xmm2",
			"vpmovsxwd 8(rax),xmm2",
			"vpmovsxwd xmm3,ymm2",
			"vpmovsxwd 0x10(rax),ymm2",
			"vpmovsxwd ymm3,zmm2",
			"vpmovsxwd 0x20(rax),zmm2",
			"vpmovsdw xmm2,xmm3{k3}",
			"vpmovsdw xmm2,8(rax){k3}",
			"vpmovsdw ymm2,xmm3{k3}",
			"vpmovsdw ymm2,0x10(rax){k3}",
			"vpmovsdw zmm2,ymm3{k3}",
			"vpmovsdw zmm2,0x20(rax){k3}",
			"pmovsxwq xmm5,xmm1",
			"pmovsxwq (rax),xmm1",
			"vpmovsxwq xmm5,xmm1",
			"vpmovsxwq (rax),xmm2",
			"vpmovsxwq xmm5,ymm1",
			"vpmovsxwq (rax),ymm2",
			"vpmovsxwq xmm3,xmm2",
			"vpmovsxwq 4(rax),xmm2",
			"vpmovsxwq xmm3,ymm2",
			"vpmovsxwq 8(rax),ymm2",
			"vpmovsxwq xmm3,zmm2",
			"vpmovsxwq 0x10(rax),zmm2",
			"vpmovsqw xmm2,xmm3{k3}",
			"vpmovsqw xmm2,4(rax){k3}",
			"vpmovsqw ymm2,xmm3{k3}",
			"vpmovsqw ymm2,8(rax){k3}",
			"vpmovsqw zmm2,xmm3{k3}",
			"vpmovsqw zmm2,0x10(rax){k3}",
			"pmovsxdq xmm5,xmm1",
			"pmovsxdq (rax),xmm1",
			"vpmovsxdq xmm5,xmm1",
			"vpmovsxdq (rax),xmm2",
			"vpmovsxdq xmm5,ymm1",
			"vpmovsxdq (rax),ymm2",
			"vpmovsxdq xmm3,xmm2",
			"vpmovsxdq 8(rax),xmm2",
			"vpmovsxdq xmm3,ymm2",
			"vpmovsxdq 0x10(rax),ymm2",
			"vpmovsxdq ymm3,zmm2",
			"vpmovsxdq 0x20(rax),zmm2",
			"vpmovsqd xmm2,xmm3{k3}",
			"vpmovsqd xmm2,8(rax){k3}",
			"vpmovsqd ymm2,xmm3{k3}",
			"vpmovsqd ymm2,0x10(rax){k3}",
			"vpmovsqd zmm2,ymm3{k3}",
			"vpmovsqd zmm2,0x20(rax){k3}",
			"vptestmb xmm3,xmm6,k2{k3}",
			"vptestmb 0x10(rax),xmm6,k2{k3}",
			"vptestmb ymm3,ymm6,k2{k3}",
			"vptestmb 0x20(rax),ymm6,k2{k3}",
			"vptestmb zmm3,zmm6,k2{k3}",
			"vptestmb 0x40(rax),zmm6,k2{k3}",
			"vptestmw xmm3,xmm6,k2{k3}",
			"vptestmw 0x10(rax),xmm6,k2{k3}",
			"vptestmw ymm3,ymm6,k2{k3}",
			"vptestmw 0x20(rax),ymm6,k2{k3}",
			"vptestmw zmm3,zmm6,k2{k3}",
			"vptestmw 0x40(rax),zmm6,k2{k3}",
			"vptestnmb xmm3,xmm6,k2{k3}",
			"vptestnmb 0x10(rax),xmm6,k2{k3}",
			"vptestnmb ymm3,ymm6,k2{k3}",
			"vptestnmb 0x20(rax),ymm6,k2{k3}",
			"vptestnmb zmm3,zmm6,k2{k3}",
			"vptestnmb 0x40(rax),zmm6,k2{k3}",
			"vptestnmw xmm3,xmm6,k2{k3}",
			"vptestnmw 0x10(rax),xmm6,k2{k3}",
			"vptestnmw ymm3,ymm6,k2{k3}",
			"vptestnmw 0x20(rax),ymm6,k2{k3}",
			"vptestnmw zmm3,zmm6,k2{k3}",
			"vptestnmw 0x40(rax),zmm6,k2{k3}",
			"vptestmd xmm3,xmm6,k2{k3}",
			"vptestmd 0x10(rax),xmm6,k2{k3}",
			"vptestmd 4(rax){1to4},xmm6,k2{k5}",
			"vptestmd ymm3,ymm6,k2{k3}",
			"vptestmd 0x20(rax),ymm6,k2{k3}",
			"vptestmd 4(rax){1to8},ymm6,k2{k5}",
			"vptestmd zmm3,zmm6,k2{k3}",
			"vptestmd 0x40(rax),zmm6,k2{k3}",
			"vptestmd 4(rax){1to16},zmm6,k2{k5}",
			"vptestmq xmm3,xmm6,k2{k3}",
			"vptestmq 0x10(rax),xmm6,k2{k3}",
			"vptestmq 8(rax){1to2},xmm6,k2{k5}",
			"vptestmq ymm3,ymm6,k2{k3}",
			"vptestmq 0x20(rax),ymm6,k2{k3}",
			"vptestmq 8(rax){1to4},ymm6,k2{k5}",
			"vptestmq zmm3,zmm6,k2{k3}",
			"vptestmq 0x40(rax),zmm6,k2{k3}",
			"vptestmq 8(rax){1to8},zmm6,k2{k5}",
			"vptestnmd xmm3,xmm6,k2{k3}",
			"vptestnmd 0x10(rax),xmm6,k2{k3}",
			"vptestnmd 4(rax){1to4},xmm6,k2{k5}",
			"vptestnmd ymm3,ymm6,k2{k3}",
			"vptestnmd 0x20(rax),ymm6,k2{k3}",
			"vptestnmd 4(rax){1to8},ymm6,k2{k5}",
			"vptestnmd zmm3,zmm6,k2{k3}",
			"vptestnmd 0x40(rax),zmm6,k2{k3}",
			"vptestnmd 4(rax){1to16},zmm6,k2{k5}",
			"vptestnmq xmm3,xmm6,k2{k3}",
			"vptestnmq 0x10(rax),xmm6,k2{k3}",
			"vptestnmq 8(rax){1to2},xmm6,k2{k5}",
			"vptestnmq ymm3,ymm6,k2{k3}",
			"vptestnmq 0x20(rax),ymm6,k2{k3}",
			"vptestnmq 8(rax){1to4},ymm6,k2{k5}",
			"vptestnmq zmm3,zmm6,k2{k3}",
			"vptestnmq 0x40(rax),zmm6,k2{k3}",
			"vptestnmq 8(rax){1to8},zmm6,k2{k5}",
			"pmuldq xmm5,xmm1",
			"pmuldq (rax),xmm1",
			"vpmuldq xmm3,xmm6,xmm2",
			"vpmuldq (rax),xmm6,xmm2",
			"vpmuldq ymm3,ymm6,ymm2",
			"vpmuldq (rax),ymm6,ymm2",
			"vpmuldq xmm3,xmm6,xmm2{k3}{z}",
			"vpmuldq 0x10(rax),xmm6,xmm2{k3}",
			"vpmuldq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpmuldq ymm3,ymm6,ymm2{k3}{z}",
			"vpmuldq 0x20(rax),ymm6,ymm2{k3}",
			"vpmuldq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpmuldq zmm3,zmm6,zmm2{k3}{z}",
			"vpmuldq 0x40(rax),zmm6,zmm2{k3}",
			"vpmuldq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpmovm2b k3,xmm2",
			"vpmovm2b k3,ymm2",
			"vpmovm2b k3,zmm2",
			"vpmovm2w k3,xmm2",
			"vpmovm2w k3,ymm2",
			"vpmovm2w k3,zmm2",
			"pcmpeqq xmm5,xmm1",
			"pcmpeqq (rax),xmm1",
			"vpcmpeqq xmm3,xmm6,xmm2",
			"vpcmpeqq (rax),xmm6,xmm2",
			"vpcmpeqq ymm3,ymm6,ymm2",
			"vpcmpeqq (rax),ymm6,ymm2",
			"vpcmpeqq xmm3,xmm6,k2{k3}",
			"vpcmpeqq 0x10(rax),xmm6,k2",
			"vpcmpeqq 8(rax){1to2},xmm6,k2{k5}",
			"vpcmpeqq ymm3,ymm6,k2{k3}",
			"vpcmpeqq 0x20(rax),ymm6,k2",
			"vpcmpeqq 8(rax){1to4},ymm6,k2{k5}",
			"vpcmpeqq zmm3,zmm6,k2{k3}",
			"vpcmpeqq 0x40(rax),zmm6,k2",
			"vpcmpeqq 8(rax){1to8},zmm6,k2{k5}",
			"vpmovb2m xmm3,k2",
			"vpmovb2m ymm3,k2",
			"vpmovb2m zmm3,k2",
			"vpmovw2m xmm3,k2",
			"vpmovw2m ymm3,k2",
			"vpmovw2m zmm3,k2",
			"movntdqa (rax),xmm1",
			"vmovntdqa (rax),xmm2",
			"vmovntdqa (rax),ymm2",
			"vmovntdqa 0x10(rax),xmm2",
			"vmovntdqa 0x20(rax),ymm2",
			"vmovntdqa 0x40(rax),zmm2",
			"vpbroadcastmb2q k3,xmm2",
			"vpbroadcastmb2q k3,ymm2",
			"vpbroadcastmb2q k3,zmm2",
			"packusdw xmm5,xmm1",
			"packusdw (rax),xmm1",
			"vpackusdw xmm3,xmm6,xmm2",
			"vpackusdw (rax),xmm6,xmm2",
			"vpackusdw ymm3,ymm6,ymm2",
			"vpackusdw (rax),ymm6,ymm2",
			"vpackusdw xmm3,xmm6,xmm2{k3}{z}",
			"vpackusdw 0x10(rax),xmm6,xmm2{k3}",
			"vpackusdw 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpackusdw ymm3,ymm6,ymm2{k3}{z}",
			"vpackusdw 0x20(rax),ymm6,ymm2{k3}",
			"vpackusdw 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpackusdw zmm3,zmm6,zmm2{k3}{z}",
			"vpackusdw 0x40(rax),zmm6,zmm2{k3}",
			"vpackusdw 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vmaskmovps (rax),xmm6,xmm2",
			"vmaskmovps (rax),ymm6,ymm2",
			"vscalefps xmm3,xmm6,xmm2{k3}{z}",
			"vscalefps 0x10(rax),xmm6,xmm2{k3}",
			"vscalefps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vscalefps ymm3,ymm6,ymm2{k3}{z}",
			"vscalefps 0x20(rax),ymm6,ymm2{k3}",
			"vscalefps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vscalefps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vscalefps 0x40(rax),zmm6,zmm2{k3}",
			"vscalefps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vscalefpd xmm3,xmm6,xmm2{k3}{z}",
			"vscalefpd 0x10(rax),xmm6,xmm2{k3}",
			"vscalefpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vscalefpd ymm3,ymm6,ymm2{k3}{z}",
			"vscalefpd 0x20(rax),ymm6,ymm2{k3}",
			"vscalefpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vscalefpd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vscalefpd 0x40(rax),zmm6,zmm2{k3}",
			"vscalefpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vmaskmovpd (rax),xmm6,xmm2",
			"vmaskmovpd (rax),ymm6,ymm2",
			"vscalefss xmm3,xmm6,xmm2{k3}",
			"vscalefss 4(rax),xmm6,xmm2{k3}",
			"vscalefsd xmm3,xmm6,xmm2{k3}{z}",
			"vscalefsd 8(rax),xmm6,xmm2{k3}",
			"vmaskmovps xmm2,xmm6,(rax)",
			"vmaskmovps ymm2,ymm6,(rax)",
			"vmaskmovpd xmm2,xmm6,(rax)",
			"vmaskmovpd ymm2,ymm6,(rax)",
			"pmovzxbw xmm5,xmm1",
			"pmovzxbw (rax),xmm1",
			"vpmovzxbw xmm5,xmm1",
			"vpmovzxbw (rax),xmm2",
			"vpmovzxbw xmm5,ymm1",
			"vpmovzxbw (rax),ymm2",
			"vpmovzxbw xmm3,xmm2",
			"vpmovzxbw 8(rax),xmm2",
			"vpmovzxbw xmm3,ymm2",
			"vpmovzxbw 0x10(rax),ymm2",
			"vpmovzxbw ymm3,zmm2",
			"vpmovzxbw 0x20(rax),zmm2",
			"vpmovwb xmm2,xmm3{k3}",
			"vpmovwb xmm2,8(rax){k3}",
			"vpmovwb ymm2,xmm3{k3}",
			"vpmovwb ymm2,0x10(rax){k3}",
			"vpmovwb zmm2,ymm3{k3}",
			"vpmovwb zmm2,0x20(rax){k3}",
			"pmovzxbd xmm5,xmm1",
			"pmovzxbd (rax),xmm1",
			"vpmovzxbd xmm5,xmm1",
			"vpmovzxbd (rax),xmm2",
			"vpmovzxbd xmm5,ymm1",
			"vpmovzxbd (rax),ymm2",
			"vpmovzxbd xmm3,xmm2",
			"vpmovzxbd 4(rax),xmm2",
			"vpmovzxbd xmm3,ymm2",
			"vpmovzxbd 8(rax),ymm2",
			"vpmovzxbd xmm3,zmm2",
			"vpmovzxbd 0x10(rax),zmm2",
			"vpmovdb xmm2,xmm3{k3}",
			"vpmovdb xmm2,4(rax){k3}",
			"vpmovdb ymm2,xmm3{k3}",
			"vpmovdb ymm2,8(rax){k3}",
			"vpmovdb zmm2,xmm3{k3}",
			"vpmovdb zmm2,0x10(rax){k3}",
			"pmovzxbq xmm5,xmm1",
			"pmovzxbq (rax),xmm1",
			"vpmovzxbq xmm5,xmm1",
			"vpmovzxbq (rax),xmm2",
			"vpmovzxbq xmm5,ymm1",
			"vpmovzxbq (rax),ymm2",
			"vpmovzxbq xmm3,xmm2",
			"vpmovzxbq 2(rax),xmm2",
			"vpmovzxbq xmm3,ymm2",
			"vpmovzxbq 4(rax),ymm2",
			"vpmovzxbq xmm3,zmm2",
			"vpmovzxbq 8(rax),zmm2",
			"vpmovqb xmm2,xmm3{k3}",
			"vpmovqb xmm2,2(rax){k3}",
			"vpmovqb ymm2,xmm3{k3}",
			"vpmovqb ymm2,4(rax){k3}",
			"vpmovqb zmm2,xmm3{k3}",
			"vpmovqb zmm2,8(rax){k3}",
			"pmovzxwd xmm5,xmm1",
			"pmovzxwd (rax),xmm1",
			"vpmovzxwd xmm5,xmm1",
			"vpmovzxwd (rax),xmm2",
			"vpmovzxwd xmm5,ymm1",
			"vpmovzxwd (rax),ymm2",
			"vpmovzxwd xmm3,xmm2",
			"vpmovzxwd 8(rax),xmm2",
			"vpmovzxwd xmm3,ymm2",
			"vpmovzxwd 0x10(rax),ymm2",
			"vpmovzxwd ymm3,zmm2",
			"vpmovzxwd 0x20(rax),zmm2",
			"vpmovdw xmm2,xmm3{k3}",
			"vpmovdw xmm2,8(rax){k3}",
			"vpmovdw ymm2,xmm3{k3}",
			"vpmovdw ymm2,0x10(rax){k3}",
			"vpmovdw zmm2,ymm3{k3}",
			"vpmovdw zmm2,0x20(rax){k3}",
			"pmovzxwq xmm5,xmm1",
			"pmovzxwq (rax),xmm1",
			"vpmovzxwq xmm5,xmm1",
			"vpmovzxwq (rax),xmm2",
			"vpmovzxwq xmm5,ymm1",
			"vpmovzxwq (rax),ymm2",
			"vpmovzxwq xmm3,xmm2",
			"vpmovzxwq 4(rax),xmm2",
			"vpmovzxwq xmm3,ymm2",
			"vpmovzxwq 8(rax),ymm2",
			"vpmovzxwq xmm3,zmm2",
			"vpmovzxwq 0x10(rax),zmm2",
			"vpmovqw xmm2,xmm3{k3}",
			"vpmovqw xmm2,4(rax){k3}",
			"vpmovqw ymm2,xmm3{k3}",
			"vpmovqw ymm2,8(rax){k3}",
			"vpmovqw zmm2,xmm3{k3}",
			"vpmovqw zmm2,0x10(rax){k3}",
			"pmovzxdq xmm5,xmm1",
			"pmovzxdq (rax),xmm1",
			"vpmovzxdq xmm5,xmm1",
			"vpmovzxdq (rax),xmm2",
			"vpmovzxdq xmm5,ymm1",
			"vpmovzxdq (rax),ymm2",
			"vpmovzxdq xmm3,xmm2",
			"vpmovzxdq 8(rax),xmm2",
			"vpmovzxdq xmm3,ymm2",
			"vpmovzxdq 0x10(rax),ymm2",
			"vpmovzxdq ymm3,zmm2",
			"vpmovzxdq 0x20(rax),zmm2",
			"vpmovqd xmm2,xmm3{k3}",
			"vpmovqd xmm2,8(rax){k3}",
			"vpmovqd ymm2,xmm3{k3}",
			"vpmovqd ymm2,0x10(rax){k3}",
			"vpmovqd zmm2,ymm3{k3}",
			"vpmovqd zmm2,0x20(rax){k3}",
			"vpermd ymm3,ymm6,ymm2",
			"vpermd (rax),ymm6,ymm2",
			"vpermd ymm3,ymm6,ymm2{k3}{z}",
			"vpermd 0x20(rax),ymm6,ymm2{k3}",
			"vpermd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpermd zmm3,zmm6,zmm2{k3}{z}",
			"vpermd 0x40(rax),zmm6,zmm2{k3}",
			"vpermd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpermq ymm3,ymm6,ymm2{k3}{z}",
			"vpermq 0x20(rax),ymm6,ymm2{k3}",
			"vpermq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpermq zmm3,zmm6,zmm2{k3}{z}",
			"vpermq 0x40(rax),zmm6,zmm2{k3}",
			"vpermq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"pcmpgtq xmm5,xmm1",
			"pcmpgtq (rax),xmm1",
			"vpcmpgtq xmm3,xmm6,xmm2",
			"vpcmpgtq (rax),xmm6,xmm2",
			"vpcmpgtq ymm3,ymm6,ymm2",
			"vpcmpgtq (rax),ymm6,ymm2",
			"vpcmpgtq xmm3,xmm6,k2{k3}",
			"vpcmpgtq 0x10(rax),xmm6,k2",
			"vpcmpgtq 8(rax){1to2},xmm6,k2{k5}",
			"vpcmpgtq ymm3,ymm6,k2{k3}",
			"vpcmpgtq 0x20(rax),ymm6,k2",
			"vpcmpgtq 8(rax){1to4},ymm6,k2{k5}",
			"vpcmpgtq zmm3,zmm6,k2{k3}",
			"vpcmpgtq 0x40(rax),zmm6,k2",
			"vpcmpgtq 8(rax){1to8},zmm6,k2{k5}",
			"pminsb xmm5,xmm1",
			"pminsb (rax),xmm1",
			"vpminsb xmm3,xmm6,xmm2",
			"vpminsb (rax),xmm6,xmm2",
			"vpminsb ymm3,ymm6,ymm2",
			"vpminsb (rax),ymm6,ymm2",
			"vpminsb xmm3,xmm6,xmm2{k3}",
			"vpminsb 0x10(rax),xmm6,xmm2{k3}",
			"vpminsb ymm3,ymm6,ymm2{k3}",
			"vpminsb 0x20(rax),ymm6,ymm2{k3}",
			"vpminsb zmm3,zmm6,zmm2{k3}",
			"vpminsb 0x40(rax),zmm6,zmm2{k3}",
			"vpmovm2d k3,xmm2",
			"vpmovm2d k3,ymm2",
			"vpmovm2d k3,zmm2",
			"vpmovm2q k3,xmm2",
			"vpmovm2q k3,ymm2",
			"vpmovm2q k3,zmm2",
			"pminsd xmm5,xmm1",
			"pminsd (rax),xmm1",
			"vpminsd xmm3,xmm6,xmm2",
			"vpminsd (rax),xmm6,xmm2",
			"vpminsd ymm3,ymm6,ymm2",
			"vpminsd (rax),ymm6,ymm2",
			"vpminsd xmm3,xmm6,xmm2{k3}{z}",
			"vpminsd 0x10(rax),xmm6,xmm2{k3}",
			"vpminsd 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpminsd ymm3,ymm6,ymm2{k3}{z}",
			"vpminsd 0x20(rax),ymm6,ymm2{k3}",
			"vpminsd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpminsd zmm3,zmm6,zmm2{k3}{z}",
			"vpminsd 0x40(rax),zmm6,zmm2{k3}",
			"vpminsd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpminsq xmm3,xmm6,xmm2{k3}{z}",
			"vpminsq 0x10(rax),xmm6,xmm2{k3}",
			"vpminsq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpminsq ymm3,ymm6,ymm2{k3}{z}",
			"vpminsq 0x20(rax),ymm6,ymm2{k3}",
			"vpminsq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpminsq zmm3,zmm6,zmm2{k3}{z}",
			"vpminsq 0x40(rax),zmm6,zmm2{k3}",
			"vpminsq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpmovd2m xmm3,k2",
			"vpmovd2m ymm3,k2",
			"vpmovd2m zmm3,k2",
			"vpmovq2m xmm3,k2",
			"vpmovq2m ymm3,k2",
			"vpmovq2m zmm3,k2",
			"pminuw xmm5,xmm1",
		};
	}
}
#endif
