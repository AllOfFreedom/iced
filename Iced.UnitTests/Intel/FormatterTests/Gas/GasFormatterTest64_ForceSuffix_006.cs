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
	public sealed class GasFormatterTest64_ForceSuffix_006 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_ForceSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_006.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_006.AllInfos_Length] {
			"vfnmsub213ps (rax),ymm6,ymm2",
			"vfnmsub213pd xmm3,xmm6,xmm2",
			"vfnmsub213pd (rax),xmm6,xmm2",
			"vfnmsub213pd ymm3,ymm6,ymm2",
			"vfnmsub213pd (rax),ymm6,ymm2",
			"vfnmsub213ps xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub213ps 0x10(rax),xmm6,xmm2{k3}",
			"vfnmsub213ps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfnmsub213ps ymm3,ymm6,ymm2{k3}{z}",
			"vfnmsub213ps 0x20(rax),ymm6,ymm2{k3}",
			"vfnmsub213ps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfnmsub213ps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfnmsub213ps 0x40(rax),zmm6,zmm2{k3}",
			"vfnmsub213ps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfnmsub213pd xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub213pd 0x10(rax),xmm6,xmm2{k3}",
			"vfnmsub213pd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfnmsub213pd ymm3,ymm6,ymm2{k3}{z}",
			"vfnmsub213pd 0x20(rax),ymm6,ymm2{k3}",
			"vfnmsub213pd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfnmsub213pd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfnmsub213pd 0x40(rax),zmm6,zmm2{k3}",
			"vfnmsub213pd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfnmsub213ss xmm3,xmm6,xmm2",
			"vfnmsub213ss (rax),xmm6,xmm2",
			"vfnmsub213sd xmm3,xmm6,xmm2",
			"vfnmsub213sd (rax),xmm6,xmm2",
			"vfnmsub213ss xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub213ss 4(rax),xmm6,xmm2{k3}",
			"vfnmsub213sd xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub213sd 8(rax),xmm6,xmm2{k3}",
			"vpmadd52luq xmm3,xmm6,xmm2{k3}{z}",
			"vpmadd52luq 0x10(rax),xmm6,xmm2{k3}",
			"vpmadd52luq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpmadd52luq ymm3,ymm6,ymm2{k3}{z}",
			"vpmadd52luq 0x20(rax),ymm6,ymm2{k3}",
			"vpmadd52luq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpmadd52luq zmm3,zmm6,zmm2{k3}{z}",
			"vpmadd52luq 0x40(rax),zmm6,zmm2{k3}",
			"vpmadd52luq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpmadd52huq xmm3,xmm6,xmm2{k3}{z}",
			"vpmadd52huq 0x10(rax),xmm6,xmm2{k3}",
			"vpmadd52huq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpmadd52huq ymm3,ymm6,ymm2{k3}{z}",
			"vpmadd52huq 0x20(rax),ymm6,ymm2{k3}",
			"vpmadd52huq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpmadd52huq zmm3,zmm6,zmm2{k3}{z}",
			"vpmadd52huq 0x40(rax),zmm6,zmm2{k3}",
			"vpmadd52huq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfmaddsub231ps xmm3,xmm6,xmm2",
			"vfmaddsub231ps (rax),xmm6,xmm2",
			"vfmaddsub231ps ymm3,ymm6,ymm2",
			"vfmaddsub231ps (rax),ymm6,ymm2",
			"vfmaddsub231pd xmm3,xmm6,xmm2",
			"vfmaddsub231pd (rax),xmm6,xmm2",
			"vfmaddsub231pd ymm3,ymm6,ymm2",
			"vfmaddsub231pd (rax),ymm6,ymm2",
			"vfmaddsub231ps xmm3,xmm6,xmm2{k3}{z}",
			"vfmaddsub231ps 0x10(rax),xmm6,xmm2{k3}",
			"vfmaddsub231ps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfmaddsub231ps ymm3,ymm6,ymm2{k3}{z}",
			"vfmaddsub231ps 0x20(rax),ymm6,ymm2{k3}",
			"vfmaddsub231ps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfmaddsub231ps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmaddsub231ps 0x40(rax),zmm6,zmm2{k3}",
			"vfmaddsub231ps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfmaddsub231pd xmm3,xmm6,xmm2{k3}{z}",
			"vfmaddsub231pd 0x10(rax),xmm6,xmm2{k3}",
			"vfmaddsub231pd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfmaddsub231pd ymm3,ymm6,ymm2{k3}{z}",
			"vfmaddsub231pd 0x20(rax),ymm6,ymm2{k3}",
			"vfmaddsub231pd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfmaddsub231pd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmaddsub231pd 0x40(rax),zmm6,zmm2{k3}",
			"vfmaddsub231pd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfmsubadd231ps xmm3,xmm6,xmm2",
			"vfmsubadd231ps (rax),xmm6,xmm2",
			"vfmsubadd231ps ymm3,ymm6,ymm2",
			"vfmsubadd231ps (rax),ymm6,ymm2",
			"vfmsubadd231pd xmm3,xmm6,xmm2",
			"vfmsubadd231pd (rax),xmm6,xmm2",
			"vfmsubadd231pd ymm3,ymm6,ymm2",
			"vfmsubadd231pd (rax),ymm6,ymm2",
			"vfmsubadd231ps xmm3,xmm6,xmm2{k3}{z}",
			"vfmsubadd231ps 0x10(rax),xmm6,xmm2{k3}",
			"vfmsubadd231ps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfmsubadd231ps ymm3,ymm6,ymm2{k3}{z}",
			"vfmsubadd231ps 0x20(rax),ymm6,ymm2{k3}",
			"vfmsubadd231ps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfmsubadd231ps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmsubadd231ps 0x40(rax),zmm6,zmm2{k3}",
			"vfmsubadd231ps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfmsubadd231pd xmm3,xmm6,xmm2{k3}{z}",
			"vfmsubadd231pd 0x10(rax),xmm6,xmm2{k3}",
			"vfmsubadd231pd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfmsubadd231pd ymm3,ymm6,ymm2{k3}{z}",
			"vfmsubadd231pd 0x20(rax),ymm6,ymm2{k3}",
			"vfmsubadd231pd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfmsubadd231pd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmsubadd231pd 0x40(rax),zmm6,zmm2{k3}",
			"vfmsubadd231pd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfmadd231ps xmm3,xmm6,xmm2",
			"vfmadd231ps (rax),xmm6,xmm2",
			"vfmadd231ps ymm3,ymm6,ymm2",
			"vfmadd231ps (rax),ymm6,ymm2",
			"vfmadd231pd xmm3,xmm6,xmm2",
			"vfmadd231pd (rax),xmm6,xmm2",
			"vfmadd231pd ymm3,ymm6,ymm2",
			"vfmadd231pd (rax),ymm6,ymm2",
			"vfmadd231ps xmm3,xmm6,xmm2{k3}{z}",
			"vfmadd231ps 0x10(rax),xmm6,xmm2{k3}",
			"vfmadd231ps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfmadd231ps ymm3,ymm6,ymm2{k3}{z}",
			"vfmadd231ps 0x20(rax),ymm6,ymm2{k3}",
			"vfmadd231ps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfmadd231ps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmadd231ps 0x40(rax),zmm6,zmm2{k3}",
			"vfmadd231ps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfmadd231pd xmm3,xmm6,xmm2{k3}{z}",
			"vfmadd231pd 0x10(rax),xmm6,xmm2{k3}",
			"vfmadd231pd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfmadd231pd ymm3,ymm6,ymm2{k3}{z}",
			"vfmadd231pd 0x20(rax),ymm6,ymm2{k3}",
			"vfmadd231pd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfmadd231pd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmadd231pd 0x40(rax),zmm6,zmm2{k3}",
			"vfmadd231pd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfmadd231ss xmm3,xmm6,xmm2",
			"vfmadd231ss (rax),xmm6,xmm2",
			"vfmadd231sd xmm3,xmm6,xmm2",
			"vfmadd231sd (rax),xmm6,xmm2",
			"vfmadd231ss xmm3,xmm6,xmm2{k3}{z}",
			"vfmadd231ss 4(rax),xmm6,xmm2{k3}",
			"vfmadd231sd xmm3,xmm6,xmm2{k3}{z}",
			"vfmadd231sd 8(rax),xmm6,xmm2{k3}",
			"vfmsub231ps xmm3,xmm6,xmm2",
			"vfmsub231ps (rax),xmm6,xmm2",
			"vfmsub231ps ymm3,ymm6,ymm2",
			"vfmsub231ps (rax),ymm6,ymm2",
			"vfmsub231pd xmm3,xmm6,xmm2",
			"vfmsub231pd (rax),xmm6,xmm2",
			"vfmsub231pd ymm3,ymm6,ymm2",
			"vfmsub231pd (rax),ymm6,ymm2",
			"vfmsub231ps xmm3,xmm6,xmm2{k3}{z}",
			"vfmsub231ps 0x10(rax),xmm6,xmm2{k3}",
			"vfmsub231ps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfmsub231ps ymm3,ymm6,ymm2{k3}{z}",
			"vfmsub231ps 0x20(rax),ymm6,ymm2{k3}",
			"vfmsub231ps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfmsub231ps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmsub231ps 0x40(rax),zmm6,zmm2{k3}",
			"vfmsub231ps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfmsub231pd xmm3,xmm6,xmm2{k3}{z}",
			"vfmsub231pd 0x10(rax),xmm6,xmm2{k3}",
			"vfmsub231pd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfmsub231pd ymm3,ymm6,ymm2{k3}{z}",
			"vfmsub231pd 0x20(rax),ymm6,ymm2{k3}",
			"vfmsub231pd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfmsub231pd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfmsub231pd 0x40(rax),zmm6,zmm2{k3}",
			"vfmsub231pd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfmsub231ss xmm3,xmm6,xmm2",
			"vfmsub231ss (rax),xmm6,xmm2",
			"vfmsub231sd xmm3,xmm6,xmm2",
			"vfmsub231sd (rax),xmm6,xmm2",
			"vfmsub231ss xmm3,xmm6,xmm2{k3}{z}",
			"vfmsub231ss 4(rax),xmm6,xmm2{k3}",
			"vfmsub231sd xmm3,xmm6,xmm2{k3}{z}",
			"vfmsub231sd 8(rax),xmm6,xmm2{k3}",
			"vfnmadd231ps xmm3,xmm6,xmm2",
			"vfnmadd231ps (rax),xmm6,xmm2",
			"vfnmadd231ps ymm3,ymm6,ymm2",
			"vfnmadd231ps (rax),ymm6,ymm2",
			"vfnmadd231pd xmm3,xmm6,xmm2",
			"vfnmadd231pd (rax),xmm6,xmm2",
			"vfnmadd231pd ymm3,ymm6,ymm2",
			"vfnmadd231pd (rax),ymm6,ymm2",
			"vfnmadd231ps xmm3,xmm6,xmm2{k3}{z}",
			"vfnmadd231ps 0x10(rax),xmm6,xmm2{k3}",
			"vfnmadd231ps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfnmadd231ps ymm3,ymm6,ymm2{k3}{z}",
			"vfnmadd231ps 0x20(rax),ymm6,ymm2{k3}",
			"vfnmadd231ps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfnmadd231ps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfnmadd231ps 0x40(rax),zmm6,zmm2{k3}",
			"vfnmadd231ps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfnmadd231pd xmm3,xmm6,xmm2{k3}{z}",
			"vfnmadd231pd 0x10(rax),xmm6,xmm2{k3}",
			"vfnmadd231pd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfnmadd231pd ymm3,ymm6,ymm2{k3}{z}",
			"vfnmadd231pd 0x20(rax),ymm6,ymm2{k3}",
			"vfnmadd231pd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfnmadd231pd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfnmadd231pd 0x40(rax),zmm6,zmm2{k3}",
			"vfnmadd231pd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfnmadd231ss xmm3,xmm6,xmm2",
			"vfnmadd231ss (rax),xmm6,xmm2",
			"vfnmadd231sd xmm3,xmm6,xmm2",
			"vfnmadd231sd (rax),xmm6,xmm2",
			"vfnmadd231ss xmm3,xmm6,xmm2{k3}{z}",
			"vfnmadd231ss 4(rax),xmm6,xmm2{k3}",
			"vfnmadd231sd xmm3,xmm6,xmm2{k3}{z}",
			"vfnmadd231sd 8(rax),xmm6,xmm2{k3}",
			"vfnmsub231ps xmm3,xmm6,xmm2",
			"vfnmsub231ps (rax),xmm6,xmm2",
			"vfnmsub231ps ymm3,ymm6,ymm2",
			"vfnmsub231ps (rax),ymm6,ymm2",
			"vfnmsub231pd xmm3,xmm6,xmm2",
			"vfnmsub231pd (rax),xmm6,xmm2",
			"vfnmsub231pd ymm3,ymm6,ymm2",
			"vfnmsub231pd (rax),ymm6,ymm2",
			"vfnmsub231ps xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub231ps 0x10(rax),xmm6,xmm2{k3}",
			"vfnmsub231ps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfnmsub231ps ymm3,ymm6,ymm2{k3}{z}",
			"vfnmsub231ps 0x20(rax),ymm6,ymm2{k3}",
			"vfnmsub231ps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfnmsub231ps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfnmsub231ps 0x40(rax),zmm6,zmm2{k3}",
			"vfnmsub231ps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfnmsub231pd xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub231pd 0x10(rax),xmm6,xmm2{k3}",
			"vfnmsub231pd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfnmsub231pd ymm3,ymm6,ymm2{k3}{z}",
			"vfnmsub231pd 0x20(rax),ymm6,ymm2{k3}",
			"vfnmsub231pd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfnmsub231pd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfnmsub231pd 0x40(rax),zmm6,zmm2{k3}",
			"vfnmsub231pd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfnmsub231ss xmm3,xmm6,xmm2",
			"vfnmsub231ss (rax),xmm6,xmm2",
			"vfnmsub231sd xmm3,xmm6,xmm2",
			"vfnmsub231sd (rax),xmm6,xmm2",
			"vfnmsub231ss xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub231ss 4(rax),xmm6,xmm2{k3}",
			"vfnmsub231sd xmm3,xmm6,xmm2{k3}{z}",
			"vfnmsub231sd 8(rax),xmm6,xmm2{k3}",
			"vpconflictd xmm3,xmm2{k3}{z}",
			"vpconflictd 0x10(rax),xmm2{k3}",
			"vpconflictd 4(rax){1to4},xmm2{k5}{z}",
			"vpconflictd ymm3,ymm2{k3}{z}",
			"vpconflictd 0x20(rax),ymm2{k3}",
			"vpconflictd 4(rax){1to8},ymm2{k5}{z}",
			"vpconflictd zmm3,zmm2{k3}{z}",
			"vpconflictd 0x40(rax),zmm2{k3}",
			"vpconflictd 4(rax){1to16},zmm2{k5}{z}",
			"vpconflictq xmm3,xmm2{k3}{z}",
			"vpconflictq 0x10(rax),xmm2{k3}",
			"vpconflictq 8(rax){1to2},xmm2{k5}{z}",
			"vpconflictq ymm3,ymm2{k3}{z}",
			"vpconflictq 0x20(rax),ymm2{k3}",
			"vpconflictq 8(rax){1to4},ymm2{k5}{z}",
			"vpconflictq zmm3,zmm2{k3}{z}",
			"vpconflictq 0x40(rax),zmm2{k3}",
			"vpconflictq 8(rax){1to8},zmm2{k5}{z}",
			"sha1nexte xmm5,xmm1",
			"sha1nexte (rax),xmm1",
			"sha1msg1 xmm5,xmm1",
			"sha1msg1 (rax),xmm1",
			"sha1msg2 xmm5,xmm1",
			"sha1msg2 (rax),xmm1",
			"sha256rnds2 xmm0,xmm5,xmm1",
			"sha256rnds2 xmm0,(rax),xmm1",
			"sha256msg1 xmm5,xmm1",
			"sha256msg1 (rax),xmm1",
			"sha256msg2 xmm5,xmm1",
			"sha256msg2 (rax),xmm1",
			"vgatherpf0dps 4(rcx,zmm4,4){k3}",
			"vgatherpf0dpd 8(rcx,ymm4,4){k3}",
			"vgatherpf1dps 4(rcx,zmm4,4){k3}",
			"vgatherpf1dpd 8(rcx,ymm4,4){k3}",
			"vscatterpf0dps 4(rcx,zmm4,4){k3}",
			"vscatterpf0dpd 8(rcx,ymm4,4){k3}",
			"vscatterpf1dps 4(rcx,zmm4,4){k3}",
			"vscatterpf1dpd 8(rcx,ymm4,4){k3}",
			"vgatherpf0qps 4(rcx,zmm4,4){k3}",
			"vgatherpf0qpd 8(rcx,zmm4,4){k3}",
			"vgatherpf1qps 4(rcx,zmm4,4){k3}",
			"vgatherpf1qpd 8(rcx,zmm4,4){k3}",
			"vscatterpf0qps 4(rcx,zmm4,4){k3}",
			"vscatterpf0qpd 8(rcx,zmm4,4){k3}",
			"vscatterpf1qps 4(rcx,zmm4,4){k3}",
			"vscatterpf1qpd 8(rcx,zmm4,4){k3}",
			"vexp2ps zmm3,zmm2{k3}",
			"vexp2ps 0x40(rax),zmm2",
			"vexp2ps 4(rax){1to16},zmm2{k3}{z}",
			"vexp2pd zmm3,zmm2{k3}",
			"vexp2pd 0x40(rax),zmm2",
			"vexp2pd 8(rax){1to8},zmm2{k3}{z}",
			"vrcp28ps zmm3,zmm2{k3}",
			"vrcp28ps 0x40(rax),zmm2",
			"vrcp28ps 4(rax){1to16},zmm2{k3}{z}",
			"vrcp28pd zmm3,zmm2{k3}",
			"vrcp28pd 0x40(rax),zmm2",
			"vrcp28pd 8(rax){1to8},zmm2{k3}{z}",
			"vrcp28ss xmm3,xmm6,xmm2{k3}",
			"vrcp28ss 4(rax),xmm6,xmm2{k3}",
			"vrcp28sd xmm3,xmm6,xmm2{k3}{z}",
			"vrcp28sd 8(rax),xmm6,xmm2{k3}",
			"vrsqrt28ps zmm3,zmm2{k3}",
			"vrsqrt28ps 0x40(rax),zmm2",
			"vrsqrt28ps 4(rax){1to16},zmm2{k3}{z}",
			"vrsqrt28pd zmm3,zmm2{k3}",
			"vrsqrt28pd 0x40(rax),zmm2",
			"vrsqrt28pd 8(rax){1to8},zmm2{k3}{z}",
			"vrsqrt28ss xmm3,xmm6,xmm2{k3}",
			"vrsqrt28ss 4(rax),xmm6,xmm2{k3}",
			"vrsqrt28sd xmm3,xmm6,xmm2{k3}{z}",
			"vrsqrt28sd 8(rax),xmm6,xmm2{k3}",
			"aesimc xmm5,xmm1",
			"aesimc (rax),xmm1",
			"vaesimc xmm3,xmm2",
			"vaesimc (rax),xmm2",
			"aesenc xmm5,xmm1",
			"aesenc (rax),xmm1",
			"vaesenc xmm3,xmm6,xmm2",
			"vaesenc (rax),xmm6,xmm2",
			"aesenclast xmm5,xmm1",
			"aesenclast (rax),xmm1",
			"vaesenclast xmm3,xmm6,xmm2",
			"vaesenclast (rax),xmm6,xmm2",
			"aesdec xmm5,xmm1",
			"aesdec (rax),xmm1",
			"vaesdec xmm3,xmm6,xmm2",
			"vaesdec (rax),xmm6,xmm2",
			"aesdeclast xmm5,xmm1",
			"aesdeclast (rax),xmm1",
			"vaesdeclast xmm3,xmm6,xmm2",
			"vaesdeclast (rax),xmm6,xmm2",
			"movbew (rax),bx",
			"movbel (rax),ebx",
			"movbeq (rax),rbx",
			"movbew bx,(rax)",
			"movbel ebx,(rax)",
			"movbeq rbx,(rax)",
			"crc32b dh,ecx",
			"crc32b (rax),ebx",
			"crc32b sil,rcx",
			"crc32b (rax),rbx",
			"crc32l esi,ecx",
			"crc32l (rax),ebx",
			"crc32q rsi,rcx",
			"crc32q (rax),rbx",
			"andnl ebx,esi,edx",
			"andnl (rax),esi,edx",
			"andnq rbx,rsi,rdx",
			"andnq (rax),rsi,rdx",
			"blsrl ebx,esi",
			"blsrl (rax),esi",
			"blsrq rbx,rsi",
			"blsrq (rax),rsi",
			"blsmskl ebx,esi",
			"blsmskl (rax),esi",
			"blsmskq rbx,rsi",
			"blsmskq (rax),rsi",
			"blsil ebx,esi",
			"blsil (rax),esi",
			"blsiq rbx,rsi",
			"blsiq (rax),rsi",
			"bzhil esi,ebx,edx",
			"bzhil esi,(rax),edx",
			"bzhiq rsi,rbx,rdx",
			"bzhiq rsi,(rax),rdx",
			"pextl ebx,esi,edx",
			"pextl (rax),esi,edx",
			"pextq rbx,rsi,rdx",
			"pextq (rax),rsi,rdx",
			"pdepl ebx,esi,edx",
			"pdepl (rax),esi,edx",
			"pdepq rbx,rsi,rdx",
			"pdepq (rax),rsi,rdx",
			"adcxl esi,ecx",
			"adcxl (rax),ebx",
			"adcxq rsi,rcx",
			"adcxq (rax),rbx",
			"adoxl esi,ecx",
			"adoxl (rax),ebx",
			"adoxq rsi,rcx",
			"adoxq (rax),rbx",
			"mulxl ebx,esi,edx",
			"mulxl (rax),esi,edx",
			"mulxq rbx,rsi,rdx",
			"mulxq (rax),rsi,rdx",
			"bextrl esi,ebx,edx",
			"bextrl esi,(rax),edx",
			"bextrq rsi,rbx,rdx",
			"bextrq rsi,(rax),rdx",
			"shlxl esi,ebx,edx",
			"shlxl esi,(rax),edx",
			"shlxq rsi,rbx,rdx",
			"shlxq rsi,(rax),rdx",
			"sarxl esi,ebx,edx",
			"sarxl esi,(rax),edx",
			"sarxq rsi,rbx,rdx",
			"sarxq rsi,(rax),rdx",
			"shrxl esi,ebx,edx",
			"shrxl esi,(rax),edx",
			"shrxq rsi,rbx,rdx",
			"shrxq rsi,(rax),rdx",
			"vpermq $-0x5b,ymm3,ymm2",
			"vpermq $-0x5b,(rax),ymm2",
			"vpermq $-0x5b,ymm3,ymm2{k3}{z}",
			"vpermq $-0x5b,0x20(rax),ymm2{k3}{z}",
			"vpermq $-0x5b,8(rax){1to4},ymm2{k5}",
			"vpermq $-0x5b,zmm3,zmm2{k3}{z}",
			"vpermq $-0x5b,0x40(rax),zmm2{k3}{z}",
			"vpermq $-0x5b,8(rax){1to8},zmm2{k5}",
			"vpermpd $-0x5b,ymm3,ymm2",
			"vpermpd $-0x5b,(rax),ymm2",
			"vpermpd $-0x5b,ymm3,ymm2{k3}{z}",
			"vpermpd $-0x5b,0x20(rax),ymm2{k3}{z}",
			"vpermpd $-0x5b,8(rax){1to4},ymm2{k5}",
			"vpermpd $-0x5b,zmm3,zmm2{k3}{z}",
			"vpermpd $-0x5b,0x40(rax),zmm2{k3}{z}",
			"vpermpd $-0x5b,8(rax){1to8},zmm2{k5}",
			"vpblendd $-0x5b,xmm3,xmm6,xmm2",
			"vpblendd $-0x5b,(rax),xmm6,xmm2",
			"vpblendd $-0x5b,ymm3,ymm6,ymm2",
			"vpblendd $-0x5b,(rax),ymm6,ymm2",
			"valignd $-0x5b,xmm3,xmm6,xmm2{k3}",
			"valignd $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"valignd $-0x5b,4(rax){1to4},xmm6,xmm2{k5}{z}",
			"valignd $-0x5b,ymm3,ymm6,ymm2{k3}",
			"valignd $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"valignd $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"valignd $-0x5b,zmm3,zmm6,zmm2{k3}",
			"valignd $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"valignd $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"valignq $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"valignq $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"valignq $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"valignq $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"valignq $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"valignq $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"valignq $-0x5b,zmm3,zmm6,zmm2{k3}{z}",
			"valignq $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"valignq $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpermilps $-0x5b,xmm3,xmm2",
			"vpermilps $-0x5b,(rax),xmm2",
			"vpermilps $-0x5b,ymm3,ymm2",
			"vpermilps $-0x5b,(rax),ymm2",
			"vpermilps $-0x5b,xmm3,xmm2{k3}{z}",
			"vpermilps $-0x5b,0x10(rax),xmm2{k3}{z}",
			"vpermilps $-0x5b,4(rax){1to4},xmm2{k5}",
			"vpermilps $-0x5b,ymm3,ymm2{k3}{z}",
			"vpermilps $-0x5b,0x20(rax),ymm2{k3}{z}",
			"vpermilps $-0x5b,4(rax){1to8},ymm2{k5}",
			"vpermilps $-0x5b,zmm3,zmm2{k3}{z}",
			"vpermilps $-0x5b,0x40(rax),zmm2{k3}{z}",
			"vpermilps $-0x5b,4(rax){1to16},zmm2{k5}",
			"vpermilpd $-0x5b,xmm3,xmm2",
			"vpermilpd $-0x5b,(rax),xmm2",
			"vpermilpd $-0x5b,ymm3,ymm2",
			"vpermilpd $-0x5b,(rax),ymm2",
			"vpermilpd $-0x5b,xmm3,xmm2{k3}{z}",
			"vpermilpd $-0x5b,0x10(rax),xmm2{k3}{z}",
			"vpermilpd $-0x5b,8(rax){1to2},xmm2{k5}",
			"vpermilpd $-0x5b,ymm3,ymm2{k3}{z}",
			"vpermilpd $-0x5b,0x20(rax),ymm2{k3}{z}",
			"vpermilpd $-0x5b,8(rax){1to4},ymm2{k5}",
			"vpermilpd $-0x5b,zmm3,zmm2{k3}{z}",
			"vpermilpd $-0x5b,0x40(rax),zmm2{k3}{z}",
			"vpermilpd $-0x5b,8(rax){1to8},zmm2{k5}",
			"vperm2f128 $-0x5b,ymm3,ymm6,ymm2",
			"vperm2f128 $-0x5b,(rax),ymm6,ymm2",
			"roundps $-0x5b,xmm5,xmm1",
			"roundps $-0x5b,(rax),xmm1",
			"vroundps $-0x5b,xmm3,xmm2",
			"vroundps $-0x5b,(rax),xmm2",
			"vroundps $-0x5b,ymm3,ymm2",
			"vroundps $-0x5b,(rax),ymm2",
			"vrndscaleps $-0x5b,xmm3,xmm2{k3}",
			"vrndscaleps $-0x5b,0x10(rax),xmm2",
			"vrndscaleps $-0x5b,4(rax){1to4},xmm2{k3}{z}",
			"vrndscaleps $-0x5b,ymm3,ymm2{k3}",
			"vrndscaleps $-0x5b,0x20(rax),ymm2",
			"vrndscaleps $-0x5b,4(rax){1to8},ymm2{k3}{z}",
			"vrndscaleps $-0x5b,zmm3,zmm2{k3}",
			"vrndscaleps $-0x5b,0x40(rax),zmm2",
			"vrndscaleps $-0x5b,4(rax){1to16},zmm2{k3}{z}",
			"roundpd $-0x5b,xmm5,xmm1",
			"roundpd $-0x5b,(rax),xmm1",
			"vroundpd $-0x5b,xmm3,xmm2",
			"vroundpd $-0x5b,(rax),xmm2",
			"vroundpd $-0x5b,ymm3,ymm2",
			"vroundpd $-0x5b,(rax),ymm2",
			"vrndscalepd $-0x5b,xmm3,xmm2{k3}",
			"vrndscalepd $-0x5b,0x10(rax),xmm2",
			"vrndscalepd $-0x5b,8(rax){1to2},xmm2{k3}{z}",
			"vrndscalepd $-0x5b,ymm3,ymm2{k3}",
			"vrndscalepd $-0x5b,0x20(rax),ymm2",
			"vrndscalepd $-0x5b,8(rax){1to4},ymm2{k3}{z}",
			"vrndscalepd $-0x5b,zmm3,zmm2{k3}",
			"vrndscalepd $-0x5b,0x40(rax),zmm2",
			"vrndscalepd $-0x5b,8(rax){1to8},zmm2{k3}{z}",
			"roundss $-0x5b,xmm5,xmm1",
			"roundss $-0x5b,(rax),xmm1",
			"vroundss $-0x5b,xmm3,xmm6,xmm2",
			"vroundss $-0x5b,(rax),xmm6,xmm2",
			"vrndscaless $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vrndscaless $-0x5b,4(rax),xmm6,xmm2{k3}",
			"roundsd $-0x5b,xmm5,xmm1",
			"roundsd $-0x5b,(rax),xmm1",
			"vroundsd $-0x5b,xmm3,xmm6,xmm2",
			"vroundsd $-0x5b,(rax),xmm6,xmm2",
			"vrndscalesd $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vrndscalesd $-0x5b,8(rax),xmm6,xmm2{k3}",
			"blendps $-0x5b,xmm5,xmm1",
			"blendps $-0x5b,(rax),xmm1",
			"vblendps $-0x5b,xmm3,xmm6,xmm2",
			"vblendps $-0x5b,(rax),xmm6,xmm2",
			"vblendps $0x5a,ymm3,ymm6,ymm2",
			"vblendps $0x5a,(rax),ymm6,ymm2",
			"blendpd $-0x5b,xmm5,xmm1",
			"blendpd $-0x5b,(rax),xmm1",
			"vblendpd $-0x5b,xmm3,xmm6,xmm2",
			"vblendpd $-0x5b,(rax),xmm6,xmm2",
			"vblendpd $0x5a,ymm3,ymm6,ymm2",
			"vblendpd $0x5a,(rax),ymm6,ymm2",
			"pblendw $-0x5b,xmm5,xmm1",
			"pblendw $-0x5b,(rax),xmm1",
			"vpblendw $-0x5b,xmm3,xmm6,xmm2",
			"vpblendw $-0x5b,(rax),xmm6,xmm2",
			"vpblendw $0x5a,ymm3,ymm6,ymm2",
			"vpblendw $0x5a,(rax),ymm6,ymm2",
			"palignr $-0x5b,mm5,mm1",
			"palignr $-0x5b,(rax),mm1",
			"palignr $-0x5b,xmm5,xmm1",
			"palignr $-0x5b,(rax),xmm1",
			"vpalignr $-0x5b,xmm3,xmm6,xmm2",
			"vpalignr $-0x5b,(rax),xmm6,xmm2",
			"vpalignr $-0x5b,ymm3,ymm6,ymm2",
			"vpalignr $-0x5b,(rax),ymm6,ymm2",
			"vpalignr $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vpalignr $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpalignr $-0x5b,ymm3,ymm6,ymm2{k3}",
			"vpalignr $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vpalignr $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vpalignr $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"pextrb $-0x5b,xmm1,ebp",
			"pextrb $-0x5b,xmm1,1(rax)",
			"pextrb $-0x5b,xmm1,rbp",
			"pextrb $-0x5b,xmm1,1(rax)",
			"vpextrb $-0x5b,xmm2,ebx",
			"vpextrb $-0x5b,xmm2,1(rax)",
			"vpextrb $-0x5b,xmm2,rbx",
			"vpextrb $-0x5b,xmm2,1(rax)",
			"vpextrb $-0x5b,xmm2,ebx",
			"vpextrb $-0x5b,xmm2,1(rax)",
			"vpextrb $-0x5b,xmm2,rbx",
			"vpextrb $-0x5b,xmm2,1(rax)",
			"pextrw $-0x5b,xmm1,ebp",
			"pextrw $-0x5b,xmm1,1(rax)",
			"pextrw $-0x5b,xmm1,rbp",
			"pextrw $-0x5b,xmm1,1(rax)",
			"vpextrw $-0x5b,xmm2,ebx",
			"vpextrw $-0x5b,xmm2,1(rax)",
			"vpextrw $-0x5b,xmm2,rbx",
			"vpextrw $-0x5b,xmm2,1(rax)",
			"vpextrw $-0x5b,xmm2,ebx",
			"vpextrw $-0x5b,xmm2,2(rax)",
			"vpextrw $-0x5b,xmm2,rbx",
			"vpextrw $-0x5b,xmm2,2(rax)",
			"pextrd $-0x5b,xmm1,ebp",
			"pextrd $-0x5b,xmm1,1(rax)",
			"pextrq $-0x5b,xmm1,rbp",
			"pextrq $-0x5b,xmm1,1(rax)",
			"vpextrd $-0x5b,xmm2,ebx",
			"vpextrd $-0x5b,xmm2,1(rax)",
			"vpextrq $-0x5b,xmm2,rbx",
			"vpextrq $-0x5b,xmm2,1(rax)",
			"vpextrd $-0x5b,xmm2,ebx",
			"vpextrd $-0x5b,xmm2,4(rax)",
			"vpextrq $-0x5b,xmm2,rbx",
			"vpextrq $-0x5b,xmm2,8(rax)",
			"extractps $-0x5b,xmm1,ebp",
			"extractps $-0x5b,xmm1,1(rax)",
			"extractps $-0x5b,xmm1,rbp",
			"extractps $-0x5b,xmm1,1(rax)",
			"vextractps $-0x5b,xmm2,ebx",
			"vextractps $-0x5b,xmm2,1(rax)",
			"vextractps $-0x5b,xmm2,rbx",
			"vextractps $-0x5b,xmm2,1(rax)",
			"vextractps $-0x5b,xmm2,ebx",
			"vextractps $-0x5b,xmm2,4(rax)",
			"vextractps $-0x5b,xmm2,rbx",
			"vextractps $-0x5b,xmm2,4(rax)",
			"vinsertf128 $-0x5b,xmm3,ymm6,ymm2",
			"vinsertf128 $-0x5b,(rax),ymm6,ymm2",
			"vinsertf32x4 $-0x5b,xmm3,ymm6,ymm2{k3}",
			"vinsertf32x4 $-0x5b,0x10(rax),ymm6,ymm2{k3}",
			"vinsertf32x4 $-0x5b,xmm3,zmm6,zmm2{k3}",
			"vinsertf32x4 $-0x5b,0x10(rax),zmm6,zmm2{k3}",
			"vinsertf64x2 $-0x5b,xmm3,ymm6,ymm2{k3}",
			"vinsertf64x2 $-0x5b,0x10(rax),ymm6,ymm2{k3}",
			"vinsertf64x2 $-0x5b,xmm3,zmm6,zmm2{k3}",
			"vinsertf64x2 $-0x5b,0x10(rax),zmm6,zmm2{k3}",
			"vextractf128 $-0x5b,ymm2,xmm3",
			"vextractf128 $-0x5b,ymm2,(rax)",
			"vextractf32x4 $-0x5b,ymm2,xmm3{k3}",
			"vextractf32x4 $-0x5b,ymm2,0x10(rax){k3}",
			"vextractf32x4 $-0x5b,zmm2,xmm3{k3}",
			"vextractf32x4 $-0x5b,zmm2,0x10(rax){k3}",
			"vextractf64x2 $-0x5b,ymm2,xmm3{k3}",
			"vextractf64x2 $-0x5b,ymm2,0x10(rax){k3}",
			"vextractf64x2 $-0x5b,zmm2,xmm3{k3}",
			"vextractf64x2 $-0x5b,zmm2,0x10(rax){k3}",
			"vinsertf32x8 $-0x5b,ymm3,zmm6,zmm2{k3}",
			"vinsertf32x8 $-0x5b,0x20(rax),zmm6,zmm2{k3}",
			"vinsertf64x4 $-0x5b,ymm3,zmm6,zmm2{k3}",
			"vinsertf64x4 $-0x5b,0x20(rax),zmm6,zmm2{k3}",
			"vextractf32x8 $-0x5b,zmm2,ymm3{k3}",
			"vextractf32x8 $-0x5b,zmm2,0x20(rax){k3}",
			"vextractf64x4 $-0x5b,zmm2,ymm3{k3}",
			"vextractf64x4 $-0x5b,zmm2,0x20(rax){k3}",
			"vcvtps2ph $-0x5b,xmm1,xmm5",
			"vcvtps2ph $-0x5b,xmm2,(rax)",
			"vcvtps2ph $-0x5b,ymm1,xmm5",
			"vcvtps2ph $-0x5b,ymm2,(rax)",
			"vcvtps2ph $-0x5b,xmm2,xmm3{k3}{z}",
			"vcvtps2ph $-0x5b,xmm2,8(rax){k3}",
			"vcvtps2ph $-0x5b,ymm2,xmm3{k3}{z}",
			"vcvtps2ph $-0x5b,ymm2,0x10(rax){k3}",
			"vcvtps2ph $-0x5b,{sae},zmm2,ymm3{k3}{z}",
			"vcvtps2ph $-0x5b,zmm2,0x20(rax){k3}",
			"vpcmpud $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpud $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpud $-0x5b,4(rax){1to4},xmm6,k2{k5}",
			"vpcmpud $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpud $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpud $-0x5b,4(rax){1to8},ymm6,k2{k5}",
			"vpcmpud $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpud $-0x5b,0x40(rax),zmm6,k2{k3}",
			"vpcmpud $-0x5b,4(rax){1to16},zmm6,k2{k5}",
			"vpcmpuq $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpuq $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpuq $-0x5b,8(rax){1to2},xmm6,k2{k5}",
			"vpcmpuq $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpuq $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpuq $-0x5b,8(rax){1to4},ymm6,k2{k5}",
			"vpcmpuq $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpuq $-0x5b,0x40(rax),zmm6,k2{k3}",
			"vpcmpuq $-0x5b,8(rax){1to8},zmm6,k2{k5}",
			"vpcmpd $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpd $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpd $-0x5b,4(rax){1to4},xmm6,k2{k5}",
			"vpcmpd $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpd $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpd $-0x5b,4(rax){1to8},ymm6,k2{k5}",
			"vpcmpd $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpd $-0x5b,0x40(rax),zmm6,k2{k3}",
			"vpcmpd $-0x5b,4(rax){1to16},zmm6,k2{k5}",
			"vpcmpq $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpq $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpq $-0x5b,8(rax){1to2},xmm6,k2{k5}",
			"vpcmpq $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpq $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpq $-0x5b,8(rax){1to4},ymm6,k2{k5}",
			"vpcmpq $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpq $-0x5b,0x40(rax),zmm6,k2{k3}",
			"vpcmpq $-0x5b,8(rax){1to8},zmm6,k2{k5}",
			"pinsrb $-0x5b,ebp,xmm1",
			"pinsrb $-0x5b,(rax),xmm1",
			"pinsrb $-0x5b,rbp,xmm1",
			"pinsrb $-0x5b,(rax),xmm1",
			"vpinsrb $-0x5b,ebx,xmm6,xmm2",
			"vpinsrb $-0x5b,(rax),xmm6,xmm2",
			"vpinsrb $-0x5b,rbx,xmm6,xmm2",
			"vpinsrb $-0x5b,(rax),xmm6,xmm2",
			"vpinsrb $-0x5b,ebx,xmm6,xmm2",
			"vpinsrb $-0x5b,1(rax),xmm6,xmm2",
			"vpinsrb $-0x5b,rbx,xmm6,xmm2",
			"vpinsrb $-0x5b,1(rax),xmm6,xmm2",
			"insertps $-0x5b,xmm5,xmm1",
			"insertps $-0x5b,(rax),xmm1",
			"vinsertps $-0x5b,xmm3,xmm6,xmm2",
			"vinsertps $-0x5b,(rax),xmm6,xmm2",
			"vinsertps $-0x5b,xmm3,xmm6,xmm2",
			"vinsertps $-0x5b,4(rax),xmm6,xmm2",
			"pinsrd $-0x5b,ebp,xmm1",
			"pinsrd $-0x5b,(rax),xmm1",
			"pinsrq $-0x5b,rbp,xmm1",
			"pinsrq $-0x5b,(rax),xmm1",
			"vpinsrd $-0x5b,ebx,xmm6,xmm2",
			"vpinsrd $-0x5b,(rax),xmm6,xmm2",
			"vpinsrq $-0x5b,rbx,xmm6,xmm2",
			"vpinsrq $-0x5b,(rax),xmm6,xmm2",
			"vpinsrd $-0x5b,ebx,xmm6,xmm2",
			"vpinsrd $-0x5b,4(rax),xmm6,xmm2",
			"vpinsrq $-0x5b,rbx,xmm6,xmm2",
			"vpinsrq $-0x5b,8(rax),xmm6,xmm2",
			"vshuff32x4 $-0x5b,ymm3,ymm6,ymm2{k3}",
			"vshuff32x4 $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vshuff32x4 $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vshuff32x4 $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vshuff32x4 $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vshuff32x4 $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vshuff64x2 $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vshuff64x2 $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vshuff64x2 $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vshuff64x2 $-0x5b,zmm3,zmm6,zmm2{k3}{z}",
			"vshuff64x2 $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vshuff64x2 $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpternlogd $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vpternlogd $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpternlogd $-0x5b,4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpternlogd $-0x5b,ymm3,ymm6,ymm2{k3}",
			"vpternlogd $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vpternlogd $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpternlogd $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vpternlogd $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vpternlogd $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpternlogq $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vpternlogq $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpternlogq $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpternlogq $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vpternlogq $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vpternlogq $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpternlogq $-0x5b,zmm3,zmm6,zmm2{k3}{z}",
			"vpternlogq $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vpternlogq $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vgetmantps $-0x5b,xmm3,xmm2{k3}",
			"vgetmantps $-0x5b,0x10(rax),xmm2",
			"vgetmantps $-0x5b,4(rax){1to4},xmm2{k3}{z}",
			"vgetmantps $-0x5b,ymm3,ymm2{k3}",
			"vgetmantps $-0x5b,0x20(rax),ymm2",
			"vgetmantps $-0x5b,4(rax){1to8},ymm2{k3}{z}",
			"vgetmantps $-0x5b,zmm3,zmm2{k3}",
			"vgetmantps $-0x5b,0x40(rax),zmm2",
			"vgetmantps $-0x5b,4(rax){1to16},zmm2{k3}{z}",
			"vgetmantpd $-0x5b,xmm3,xmm2{k3}",
			"vgetmantpd $-0x5b,0x10(rax),xmm2",
			"vgetmantpd $-0x5b,8(rax){1to2},xmm2{k3}{z}",
			"vgetmantpd $-0x5b,ymm3,ymm2{k3}",
			"vgetmantpd $-0x5b,0x20(rax),ymm2",
			"vgetmantpd $-0x5b,8(rax){1to4},ymm2{k3}{z}",
			"vgetmantpd $-0x5b,zmm3,zmm2{k3}",
			"vgetmantpd $-0x5b,0x40(rax),zmm2",
			"vgetmantpd $-0x5b,8(rax){1to8},zmm2{k3}{z}",
			"vgetmantss $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vgetmantss $-0x5b,4(rax),xmm6,xmm2{k3}",
			"vgetmantsd $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vgetmantsd $-0x5b,8(rax),xmm6,xmm2{k3}",
			"kshiftrw $-0x5b,k3,k2",
			"kshiftrb $-0x5b,k3,k2",
			"kshiftrq $-0x5b,k3,k2",
			"kshiftrd $-0x5b,k3,k2",
			"kshiftlw $-0x5b,k3,k2",
			"kshiftlb $-0x5b,k3,k2",
			"kshiftlq $-0x5b,k3,k2",
			"kshiftld $-0x5b,k3,k2",
			"vinserti128 $-0x5b,xmm3,ymm6,ymm2",
			"vinserti128 $-0x5b,(rax),ymm6,ymm2",
			"vinserti32x4 $-0x5b,xmm3,ymm6,ymm2{k3}",
			"vinserti32x4 $-0x5b,0x10(rax),ymm6,ymm2{k3}",
			"vinserti32x4 $-0x5b,xmm3,zmm6,zmm2{k3}",
			"vinserti32x4 $-0x5b,0x10(rax),zmm6,zmm2{k3}",
			"vinserti64x2 $-0x5b,xmm3,ymm6,ymm2{k3}",
			"vinserti64x2 $-0x5b,0x10(rax),ymm6,ymm2{k3}",
			"vinserti64x2 $-0x5b,xmm3,zmm6,zmm2{k3}",
			"vinserti64x2 $-0x5b,0x10(rax),zmm6,zmm2{k3}",
			"vextracti128 $-0x5b,ymm2,xmm3",
			"vextracti128 $-0x5b,ymm2,(rax)",
			"vextracti32x4 $-0x5b,ymm2,xmm3{k3}",
			"vextracti32x4 $-0x5b,ymm2,0x10(rax){k3}",
			"vextracti32x4 $-0x5b,zmm2,xmm3{k3}",
			"vextracti32x4 $-0x5b,zmm2,0x10(rax){k3}",
			"vextracti64x2 $-0x5b,ymm2,xmm3{k3}",
			"vextracti64x2 $-0x5b,ymm2,0x10(rax){k3}",
			"vextracti64x2 $-0x5b,zmm2,xmm3{k3}",
			"vextracti64x2 $-0x5b,zmm2,0x10(rax){k3}",
			"vinserti32x8 $-0x5b,ymm3,zmm6,zmm2{k3}",
			"vinserti32x8 $-0x5b,0x20(rax),zmm6,zmm2{k3}",
			"vinserti64x4 $-0x5b,ymm3,zmm6,zmm2{k3}",
			"vinserti64x4 $-0x5b,0x20(rax),zmm6,zmm2{k3}",
			"vextracti32x8 $-0x5b,zmm2,ymm3{k3}",
			"vextracti32x8 $-0x5b,zmm2,0x20(rax){k3}",
			"vextracti64x4 $-0x5b,zmm2,ymm3{k3}",
			"vextracti64x4 $-0x5b,zmm2,0x20(rax){k3}",
			"vpcmpub $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpub $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpub $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpub $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpub $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpub $-0x5b,0x40(rax),zmm6,k2{k3}",
			"vpcmpuw $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpuw $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpuw $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpuw $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpuw $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpuw $-0x5b,0x40(rax),zmm6,k2{k3}",
			"vpcmpb $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpb $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpb $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpb $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpb $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpb $-0x5b,0x40(rax),zmm6,k2{k3}",
			"vpcmpw $-0x5b,xmm3,xmm6,k2{k3}",
			"vpcmpw $-0x5b,0x10(rax),xmm6,k2{k3}",
			"vpcmpw $-0x5b,ymm3,ymm6,k2{k3}",
			"vpcmpw $-0x5b,0x20(rax),ymm6,k2{k3}",
			"vpcmpw $-0x5b,zmm3,zmm6,k2{k3}",
			"vpcmpw $-0x5b,0x40(rax),zmm6,k2{k3}",
			"dpps $-0x5b,xmm5,xmm1",
			"dpps $-0x5b,(rax),xmm1",
			"vdpps $-0x5b,xmm3,xmm6,xmm2",
			"vdpps $-0x5b,(rax),xmm6,xmm2",
			"vdpps $0x5a,ymm3,ymm6,ymm2",
			"vdpps $0x5a,(rax),ymm6,ymm2",
			"dppd $-0x5b,xmm5,xmm1",
			"dppd $-0x5b,(rax),xmm1",
			"vdppd $-0x5b,xmm3,xmm6,xmm2",
			"vdppd $-0x5b,(rax),xmm6,xmm2",
			"mpsadbw $-0x5b,xmm5,xmm1",
			"mpsadbw $-0x5b,(rax),xmm1",
			"vmpsadbw $-0x5b,xmm3,xmm6,xmm2",
			"vmpsadbw $-0x5b,(rax),xmm6,xmm2",
			"vmpsadbw $-0x5b,ymm3,ymm6,ymm2",
			"vmpsadbw $-0x5b,(rax),ymm6,ymm2",
			"vdbpsadbw $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vdbpsadbw $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vdbpsadbw $-0x5b,ymm3,ymm6,ymm2{k3}",
			"vdbpsadbw $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vdbpsadbw $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vdbpsadbw $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vshufi32x4 $-0x5b,ymm3,ymm6,ymm2{k3}",
			"vshufi32x4 $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vshufi32x4 $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vshufi32x4 $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vshufi32x4 $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vshufi32x4 $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vshufi64x2 $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vshufi64x2 $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vshufi64x2 $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vshufi64x2 $-0x5b,zmm3,zmm6,zmm2{k3}{z}",
			"vshufi64x2 $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vshufi64x2 $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"pclmulqdq $-0x5b,xmm5,xmm1",
			"pclmulqdq $-0x5b,(rax),xmm1",
			"vpclmulqdq $-0x5b,xmm3,xmm6,xmm2",
			"vpclmulqdq $-0x5b,(rax),xmm6,xmm2",
			"vperm2i128 $-0x5b,ymm3,ymm6,ymm2",
			"vperm2i128 $-0x5b,(rax),ymm6,ymm2",
			"vblendvps xmm4,xmm3,xmm6,xmm2",
			"vblendvps xmm4,(rax),xmm6,xmm2",
			"vblendvps ymm5,ymm3,ymm6,ymm2",
			"vblendvps ymm5,(rax),ymm6,ymm2",
			"vblendvpd xmm4,xmm3,xmm6,xmm2",
			"vblendvpd xmm4,(rax),xmm6,xmm2",
			"vblendvpd ymm5,ymm3,ymm6,ymm2",
			"vblendvpd ymm5,(rax),ymm6,ymm2",
			"vpblendvb xmm4,xmm3,xmm6,xmm2",
			"vpblendvb xmm4,(rax),xmm6,xmm2",
			"vpblendvb ymm5,ymm3,ymm6,ymm2",
			"vpblendvb ymm5,(rax),ymm6,ymm2",
			"vrangeps $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vrangeps $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vrangeps $-0x5b,4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vrangeps $-0x5b,ymm3,ymm6,ymm2{k3}",
			"vrangeps $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vrangeps $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vrangeps $-0x5b,{sae},zmm3,zmm6,zmm2{k3}{z}",
			"vrangeps $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vrangeps $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vrangepd $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vrangepd $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vrangepd $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vrangepd $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vrangepd $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vrangepd $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vrangepd $-0x5b,{sae},zmm3,zmm6,zmm2{k3}{z}",
			"vrangepd $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vrangepd $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vrangess $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vrangess $-0x5b,4(rax),xmm6,xmm2{k3}",
			"vrangesd $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vrangesd $-0x5b,8(rax),xmm6,xmm2{k3}",
			"vfixupimmps $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vfixupimmps $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vfixupimmps $-0x5b,4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vfixupimmps $-0x5b,ymm3,ymm6,ymm2{k3}",
			"vfixupimmps $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vfixupimmps $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vfixupimmps $-0x5b,{sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfixupimmps $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vfixupimmps $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vfixupimmpd $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vfixupimmpd $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vfixupimmpd $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vfixupimmpd $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vfixupimmpd $-0x5b,0x20(rax),ymm6,ymm2{k3}",
			"vfixupimmpd $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vfixupimmpd $-0x5b,{sae},zmm3,zmm6,zmm2{k3}{z}",
			"vfixupimmpd $-0x5b,0x40(rax),zmm6,zmm2{k3}",
			"vfixupimmpd $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vfixupimmss $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vfixupimmss $-0x5b,4(rax),xmm6,xmm2{k3}",
			"vfixupimmsd $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vfixupimmsd $-0x5b,8(rax),xmm6,xmm2{k3}",
			"vreduceps $-0x5b,xmm3,xmm2{k3}",
			"vreduceps $-0x5b,0x10(rax),xmm2",
			"vreduceps $-0x5b,4(rax){1to4},xmm2{k3}{z}",
			"vreduceps $-0x5b,ymm3,ymm2{k3}",
			"vreduceps $-0x5b,0x20(rax),ymm2",
			"vreduceps $-0x5b,4(rax){1to8},ymm2{k3}{z}",
			"vreduceps $-0x5b,zmm3,zmm2{k3}",
			"vreduceps $-0x5b,0x40(rax),zmm2",
			"vreduceps $-0x5b,4(rax){1to16},zmm2{k3}{z}",
			"vreducepd $-0x5b,xmm3,xmm2{k3}",
			"vreducepd $-0x5b,0x10(rax),xmm2",
			"vreducepd $-0x5b,8(rax){1to2},xmm2{k3}{z}",
			"vreducepd $-0x5b,ymm3,ymm2{k3}",
			"vreducepd $-0x5b,0x20(rax),ymm2",
			"vreducepd $-0x5b,8(rax){1to4},ymm2{k3}{z}",
			"vreducepd $-0x5b,zmm3,zmm2{k3}",
			"vreducepd $-0x5b,0x40(rax),zmm2",
			"vreducepd $-0x5b,8(rax){1to8},zmm2{k3}{z}",
			"vreducess $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vreducess $-0x5b,4(rax),xmm6,xmm2{k3}",
			"vreducesd $-0x5b,xmm3,xmm6,xmm2{k3}{z}",
			"vreducesd $-0x5b,8(rax),xmm6,xmm2{k3}",
			"pcmpestrm $-0x5b,xmm5,xmm1",
			"pcmpestrm $-0x5b,(rax),xmm1",
			"vpcmpestrm $-0x5b,xmm3,xmm2",
			"vpcmpestrm $-0x5b,(rax),xmm2",
			"pcmpestri $-0x5b,xmm5,xmm1",
			"pcmpestri $-0x5b,(rax),xmm1",
			"vpcmpestri $-0x5b,xmm3,xmm2",
			"vpcmpestri $-0x5b,(rax),xmm2",
			"pcmpistrm $-0x5b,xmm5,xmm1",
			"pcmpistrm $-0x5b,(rax),xmm1",
			"vpcmpistrm $-0x5b,xmm3,xmm2",
			"vpcmpistrm $-0x5b,(rax),xmm2",
			"pcmpistri $-0x5b,xmm5,xmm1",
			"pcmpistri $-0x5b,(rax),xmm1",
			"vpcmpistri $-0x5b,xmm3,xmm2",
			"vpcmpistri $-0x5b,(rax),xmm2",
			"vfpclasspsx $-0x5b,xmm3,k2{k3}",
			"vfpclasspsx $-0x5b,0x10(rax),k2{k3}",
			"vfpclasspsx $-0x5b,4(rax){1to4},k2{k5}",
			"vfpclasspsy $-0x5b,ymm3,k2{k3}",
			"vfpclasspsy $-0x5b,0x20(rax),k2{k3}",
			"vfpclasspsy $-0x5b,4(rax){1to8},k2{k5}",
			"vfpclasspsz $-0x5b,zmm3,k2{k3}",
			"vfpclasspsz $-0x5b,0x40(rax),k2{k3}",
			"vfpclasspsz $-0x5b,4(rax){1to16},k2{k5}",
			"vfpclasspdx $-0x5b,xmm3,k2{k3}",
			"vfpclasspdx $-0x5b,0x10(rax),k2{k3}",
			"vfpclasspdx $-0x5b,8(rax){1to2},k2{k5}",
			"vfpclasspdy $-0x5b,ymm3,k2{k3}",
			"vfpclasspdy $-0x5b,0x20(rax),k2{k3}",
			"vfpclasspdy $-0x5b,8(rax){1to4},k2{k5}",
			"vfpclasspdz $-0x5b,zmm3,k2{k3}",
			"vfpclasspdz $-0x5b,0x40(rax),k2{k3}",
			"vfpclasspdz $-0x5b,8(rax){1to8},k2{k5}",
			"vfpclassss $-0x5b,xmm3,k2{k3}",
			"vfpclassss $-0x5b,4(rax),k2{k3}",
			"vfpclasssd $-0x5b,xmm3,k2{k3}",
			"vfpclasssd $-0x5b,8(rax),k2{k3}",
			"sha1rnds4 $-0x5b,xmm5,xmm1",
			"sha1rnds4 $-0x5b,(rax),xmm1",
			"aeskeygenassist $-0x5b,xmm5,xmm1",
			"aeskeygenassist $0x5a,(rax),xmm1",
			"vaeskeygenassist $-0x5b,xmm3,xmm2",
			"vaeskeygenassist $0x5a,(rax),xmm2",
			"rorxl $-0x5b,ebx,edx",
			"rorxl $0x5a,(rax),edx",
			"rorxq $-0x5b,rbx,rdx",
			"rorxq $-0x5b,(rax),rdx",
			"outsb fs:(rsi),dx",
			"outsw fs:(rsi),dx",
			"outsl fs:(rsi),dx",
			"movsb fs:(rsi),es:(rdi)",
			"movsw fs:(rsi),es:(rdi)",
			"movsl fs:(rsi),es:(rdi)",
			"movsq fs:(rsi),es:(rdi)",
			"cmpsb es:(rdi),fs:(rsi)",
			"cmpsw es:(rdi),fs:(rsi)",
			"cmpsl es:(rdi),fs:(rsi)",
			"cmpsq es:(rdi),fs:(rsi)",
			"lodsb fs:(rsi),al",
			"lodsw fs:(rsi),ax",
			"lodsl fs:(rsi),eax",
			"lodsq fs:(rsi),rax",
			"xlatb (ebx)",
			"xlatb fs:(rbx)",
			"fs maskmovq mm3,mm2",
			"fs maskmovdqu xmm3,xmm2",
			"fs vmaskmovdqu xmm3,xmm2",
			"addr32 monitor",
			"(bad)",
			"movabsb fs:0xf0debc9a78563412,al",
			"addr32 movb fs:0x78563412,al",
			"movabsw fs:0xf0debc9a78563412,ax",
			"addr32 movw fs:0x78563412,ax",
			"movabsl fs:0xf0debc9a78563412,eax",
			"addr32 movl fs:0x78563412,eax",
			"movabsq fs:0xf0debc9a78563412,rax",
			"addr32 movq fs:0x78563412,rax",
			"movabsb al,fs:0xf0debc9a78563412",
		};
	}
}
#endif
