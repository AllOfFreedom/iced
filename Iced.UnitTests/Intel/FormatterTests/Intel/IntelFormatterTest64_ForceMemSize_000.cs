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

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class IntelFormatterTest64_ForceMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, IntelFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_000.AllInfos_Length] {
			"add dh, cl",
			"add byte ptr [rax], bh",
			"add si, cx",
			"add word ptr [rax], bx",
			"add esi, ecx",
			"add dword ptr [rax], ebx",
			"add rsi, rcx",
			"add qword ptr [rax], rbx",
			"add cl, dh",
			"add bh, byte ptr [rax]",
			"add cx, si",
			"add bx, word ptr [rax]",
			"add ecx, esi",
			"add ebx, dword ptr [rax]",
			"add rcx, rsi",
			"add rbx, qword ptr [rax]",
			"add al, -0x5b",
			"add ax, 0x5aa5",
			"add eax, 0x12345aa5",
			"add rax, -0x7dcba55b",
			"or dh, cl",
			"or byte ptr [rax], bh",
			"or si, cx",
			"or word ptr [rax], bx",
			"or esi, ecx",
			"or dword ptr [rax], ebx",
			"or rsi, rcx",
			"or qword ptr [rax], rbx",
			"or cl, dh",
			"or bh, byte ptr [rax]",
			"or cx, si",
			"or bx, word ptr [rax]",
			"or ecx, esi",
			"or ebx, dword ptr [rax]",
			"or rcx, rsi",
			"or rbx, qword ptr [rax]",
			"or al, -0x5b",
			"or ax, 0x5aa5",
			"or eax, 0x12345aa5",
			"or rax, -0x7dcba55b",
			"adc dh, cl",
			"adc byte ptr [rax], bh",
			"adc si, cx",
			"adc word ptr [rax], bx",
			"adc esi, ecx",
			"adc dword ptr [rax], ebx",
			"adc rsi, rcx",
			"adc qword ptr [rax], rbx",
			"adc cl, dh",
			"adc bh, byte ptr [rax]",
			"adc cx, si",
			"adc bx, word ptr [rax]",
			"adc ecx, esi",
			"adc ebx, dword ptr [rax]",
			"adc rcx, rsi",
			"adc rbx, qword ptr [rax]",
			"adc al, -0x5b",
			"adc ax, 0x5aa5",
			"adc eax, 0x12345aa5",
			"adc rax, -0x7dcba55b",
			"sbb dh, cl",
			"sbb byte ptr [rax], bh",
			"sbb si, cx",
			"sbb word ptr [rax], bx",
			"sbb esi, ecx",
			"sbb dword ptr [rax], ebx",
			"sbb rsi, rcx",
			"sbb qword ptr [rax], rbx",
			"sbb cl, dh",
			"sbb bh, byte ptr [rax]",
			"sbb cx, si",
			"sbb bx, word ptr [rax]",
			"sbb ecx, esi",
			"sbb ebx, dword ptr [rax]",
			"sbb rcx, rsi",
			"sbb rbx, qword ptr [rax]",
			"sbb al, -0x5b",
			"sbb ax, 0x5aa5",
			"sbb eax, 0x12345aa5",
			"sbb rax, -0x7dcba55b",
			"and dh, cl",
			"and byte ptr [rax], bh",
			"and si, cx",
			"and word ptr [rax], bx",
			"and esi, ecx",
			"and dword ptr [rax], ebx",
			"and rsi, rcx",
			"and qword ptr [rax], rbx",
			"and cl, dh",
			"and bh, byte ptr [rax]",
			"and cx, si",
			"and bx, word ptr [rax]",
			"and ecx, esi",
			"and ebx, dword ptr [rax]",
			"and rcx, rsi",
			"and rbx, qword ptr [rax]",
			"and al, -0x5b",
			"and ax, 0x5aa5",
			"and eax, 0x12345aa5",
			"and rax, -0x7dcba55b",
			"sub dh, cl",
			"sub byte ptr [rax], bh",
			"sub si, cx",
			"sub word ptr [rax], bx",
			"sub esi, ecx",
			"sub dword ptr [rax], ebx",
			"sub rsi, rcx",
			"sub qword ptr [rax], rbx",
			"sub cl, dh",
			"sub bh, byte ptr [rax]",
			"sub cx, si",
			"sub bx, word ptr [rax]",
			"sub ecx, esi",
			"sub ebx, dword ptr [rax]",
			"sub rcx, rsi",
			"sub rbx, qword ptr [rax]",
			"sub al, -0x5b",
			"sub ax, 0x5aa5",
			"sub eax, 0x12345aa5",
			"sub rax, -0x7dcba55b",
			"xor dh, cl",
			"xor byte ptr [rax], bh",
			"xor si, cx",
			"xor word ptr [rax], bx",
			"xor esi, ecx",
			"xor dword ptr [rax], ebx",
			"xor rsi, rcx",
			"xor qword ptr [rax], rbx",
			"xor cl, dh",
			"xor bh, byte ptr [rax]",
			"xor cx, si",
			"xor bx, word ptr [rax]",
			"xor ecx, esi",
			"xor ebx, dword ptr [rax]",
			"xor rcx, rsi",
			"xor rbx, qword ptr [rax]",
			"xor al, -0x5b",
			"xor ax, 0x5aa5",
			"xor eax, 0x12345aa5",
			"xor rax, -0x7dcba55b",
			"cmp dh, cl",
			"cmp byte ptr [rax], bh",
			"cmp si, cx",
			"cmp word ptr [rax], bx",
			"cmp esi, ecx",
			"cmp dword ptr [rax], ebx",
			"cmp rsi, rcx",
			"cmp qword ptr [rax], rbx",
			"cmp cl, dh",
			"cmp bh, byte ptr [rax]",
			"cmp cx, si",
			"cmp bx, word ptr [rax]",
			"cmp ecx, esi",
			"cmp ebx, dword ptr [rax]",
			"cmp rcx, rsi",
			"cmp rbx, qword ptr [rax]",
			"cmp al, -0x5b",
			"cmp ax, 0x5aa5",
			"cmp eax, 0x12345aa5",
			"cmp rax, -0x7dcba55b",
			"push ax",
			"push r8w",
			"push rax",
			"push r8",
			"push cx",
			"push r9w",
			"push rcx",
			"push r9",
			"push dx",
			"push r10w",
			"push rdx",
			"push r10",
			"push bx",
			"push r11w",
			"push rbx",
			"push r11",
			"push sp",
			"push r12w",
			"push rsp",
			"push r12",
			"push bp",
			"push r13w",
			"push rbp",
			"push r13",
			"push si",
			"push r14w",
			"push rsi",
			"push r14",
			"push di",
			"push r15w",
			"push rdi",
			"push r15",
			"pop ax",
			"pop r8w",
			"pop rax",
			"pop r8",
			"pop cx",
			"pop r9w",
			"pop rcx",
			"pop r9",
			"pop dx",
			"pop r10w",
			"pop rdx",
			"pop r10",
			"pop bx",
			"pop r11w",
			"pop rbx",
			"pop r11",
			"pop sp",
			"pop r12w",
			"pop rsp",
			"pop r12",
			"pop bp",
			"pop r13w",
			"pop rbp",
			"pop r13",
			"pop si",
			"pop r14w",
			"pop rsi",
			"pop r14",
			"pop di",
			"pop r15w",
			"pop rdi",
			"pop r15",
			"movsxd cx, si",
			"movsxd bx, word ptr [rax]",
			"movsxd ecx, esi",
			"movsxd ebx, dword ptr [rax]",
			"movsxd rcx, esi",
			"movsxd rbx, dword ptr [rax]",
			"data16 push -0x5aa6",
			"push -0x7bed5aa6",
			"imul cx, si, 0x5aa5",
			"imul bx, word ptr [rax], -0x5aa6",
			"imul ecx, esi, 0x3412a55a",
			"imul ebx, dword ptr [rax], 0x3412a55a",
			"imul rcx, rsi, -0x7bed5aa6",
			"imul rbx, qword ptr [rax], -0x7bed5aa6",
			"data16 push -0x5b",
			"push -0x5b",
			"imul cx, si, -0x5b",
			"imul bx, word ptr [rax], -0x5b",
			"imul ecx, esi, -0x5b",
			"imul ebx, dword ptr [rax], -0x5b",
			"imul rcx, rsi, -0x5b",
			"imul rbx, qword ptr [rax], -0x5b",
			"insb byte ptr [edi], dx",
			"insb byte ptr [rdi], dx",
			"insw word ptr [edi], dx",
			"insw word ptr [rdi], dx",
			"insd dword ptr [edi], dx",
			"insd dword ptr [rdi], dx",
			"outsb dx, byte ptr [esi]",
			"outsb dx, byte ptr [rsi]",
			"outsw dx, word ptr [esi]",
			"outsw dx, word ptr [rsi]",
			"outsd dx, dword ptr [esi]",
			"outsd dx, dword ptr [rsi]",
			"jo short 0x800000000000004c",
			"jno short 0x800000000000004c",
			"jb short 0x800000000000004c",
			"jae short 0x800000000000004c",
			"je short 0x800000000000004c",
			"jne short 0x800000000000004c",
			"jbe short 0x800000000000004c",
			"ja short 0x800000000000004c",
			"js short 0x800000000000004c",
			"jns short 0x800000000000004c",
			"jp short 0x800000000000004c",
			"jnp short 0x800000000000004c",
			"jl short 0x800000000000004c",
			"jge short 0x800000000000004c",
			"jle short 0x800000000000004c",
			"jg short 0x800000000000004c",
			"add cl, 0x5a",
			"add byte ptr [rax], 0x5a",
			"or dl, -0x5b",
			"or byte ptr [rax], -0x5b",
			"adc bl, 0x5a",
			"adc byte ptr [rax], 0x5a",
			"sbb ah, -0x5b",
			"sbb byte ptr [rax], -0x5b",
			"and ch, 0x5a",
			"and byte ptr [rax], 0x5a",
			"sub dh, -0x5b",
			"sub byte ptr [rax], -0x5b",
			"xor bh, 0x5a",
			"xor byte ptr [rax], 0x5a",
			"cmp al, -0x5b",
			"cmp byte ptr [rax], -0x5b",
			"add cx, -0x5aa6",
			"add word ptr [rax], -0x5aa6",
			"add ecx, 0x3412a55a",
			"add dword ptr [rax], 0x3412a55a",
			"add rcx, -0x7bed5aa6",
			"add qword ptr [rax], -0x7bed5aa6",
			"or dx, 0x5aa5",
			"or word ptr [rax], 0x5aa5",
			"or edx, -0x5476a55b",
			"or dword ptr [rax], -0x5476a55b",
			"or rdx, -0x7bed5aa6",
			"or qword ptr [rax], -0x7bed5aa6",
			"adc bx, -0x5aa6",
			"adc word ptr [rax], -0x5aa6",
			"adc ebx, 0x3412a55a",
			"adc dword ptr [rax], 0x3412a55a",
			"adc rbx, -0x7bed5aa6",
			"adc qword ptr [rax], -0x7bed5aa6",
			"sbb sp, 0x5aa5",
			"sbb word ptr [rax], 0x5aa5",
			"sbb esp, -0x5476a55b",
			"sbb dword ptr [rax], -0x5476a55b",
			"sbb rsp, -0x7bed5aa6",
			"sbb qword ptr [rax], -0x7bed5aa6",
			"and bp, -0x5aa6",
			"and word ptr [rax], -0x5aa6",
			"and ebp, 0x3412a55a",
			"and dword ptr [rax], 0x3412a55a",
			"and rbp, -0x7bed5aa6",
			"and qword ptr [rax], -0x7bed5aa6",
			"sub si, 0x5aa5",
			"sub word ptr [rax], 0x5aa5",
			"sub esi, -0x5476a55b",
			"sub dword ptr [rax], -0x5476a55b",
			"sub rsi, -0x7bed5aa6",
			"sub qword ptr [rax], -0x7bed5aa6",
			"xor di, -0x5aa6",
			"xor word ptr [rax], -0x5aa6",
			"xor edi, 0x3412a55a",
			"xor dword ptr [rax], 0x3412a55a",
			"xor rdi, -0x7bed5aa6",
			"xor qword ptr [rax], -0x7bed5aa6",
			"cmp ax, 0x5aa5",
			"cmp word ptr [rax], 0x5aa5",
			"cmp eax, -0x5476a55b",
			"cmp dword ptr [rax], -0x5476a55b",
			"cmp r8, -0x7bed5aa6",
			"cmp qword ptr [rax], -0x7bed5aa6",
			"add cx, -0x5b",
			"add word ptr [rax], -0x5b",
			"add ecx, -0x5b",
			"add dword ptr [rax], -0x5b",
			"add rcx, -0x5b",
			"add qword ptr [rax], -0x5b",
			"or dx, -0x5b",
			"or word ptr [rax], -0x5b",
			"or edx, -0x5b",
			"or dword ptr [rax], -0x5b",
			"or rdx, -0x5b",
			"or qword ptr [rax], -0x5b",
			"adc bx, -0x5b",
			"adc word ptr [rax], -0x5b",
			"adc ebx, -0x5b",
			"adc dword ptr [rax], -0x5b",
			"adc rbx, -0x5b",
			"adc qword ptr [rax], -0x5b",
			"sbb sp, -0x5b",
			"sbb word ptr [rax], -0x5b",
			"sbb esp, -0x5b",
			"sbb dword ptr [rax], -0x5b",
			"sbb rsp, -0x5b",
			"sbb qword ptr [rax], -0x5b",
			"and bp, -0x5b",
			"and word ptr [rax], -0x5b",
			"and ebp, -0x5b",
			"and dword ptr [rax], -0x5b",
			"and rbp, -0x5b",
			"and qword ptr [rax], -0x5b",
			"sub si, -0x5b",
			"sub word ptr [rax], -0x5b",
			"sub esi, -0x5b",
			"sub dword ptr [rax], -0x5b",
			"sub rsi, -0x5b",
			"sub qword ptr [rax], -0x5b",
			"xor di, -0x5b",
			"xor word ptr [rax], -0x5b",
			"xor edi, -0x5b",
			"xor dword ptr [rax], -0x5b",
			"xor rdi, -0x5b",
			"xor qword ptr [rax], -0x5b",
			"cmp ax, -0x5b",
			"cmp word ptr [rax], -0x5b",
			"cmp eax, -0x5b",
			"cmp dword ptr [rax], -0x5b",
			"cmp r8, -0x5b",
			"cmp qword ptr [rax], -0x5b",
			"test dh, cl",
			"test byte ptr [rax], bh",
			"test si, cx",
			"test word ptr [rax], bx",
			"test esi, ecx",
			"test dword ptr [rax], ebx",
			"test rsi, rcx",
			"test qword ptr [rax], rbx",
			"xchg dh, cl",
			"xchg byte ptr [rax], bh",
			"xchg si, cx",
			"xchg word ptr [rax], bx",
			"xchg esi, ecx",
			"xchg dword ptr [rax], ebx",
			"xchg rsi, rcx",
			"xchg qword ptr [rax], rbx",
			"mov dh, cl",
			"mov byte ptr [rax], bh",
			"mov si, cx",
			"mov word ptr [rax], bx",
			"mov esi, ecx",
			"mov dword ptr [rax], ebx",
			"mov rsi, rcx",
			"mov qword ptr [rax], rbx",
			"mov cl, dh",
			"mov bh, byte ptr [rax]",
			"mov cx, si",
			"mov bx, word ptr [rax]",
			"mov ecx, esi",
			"mov ebx, dword ptr [rax]",
			"mov rcx, rsi",
			"mov rbx, qword ptr [rax]",
			"mov si, cs",
			"data16 mov word ptr [rax], ds",
			"mov esi, cs",
			"mov word ptr [rax], ds",
			"mov rsi, cs",
			"data64 mov word ptr [rax], ds",
			"lea bx, [rax]",
			"lea ebx, [rax]",
			"lea rbx, [rax]",
			"mov fs, si",
			"data16 mov ds, word ptr [rax]",
			"mov fs, esi",
			"mov ds, word ptr [rax]",
			"mov fs, rsi",
			"data64 mov ds, word ptr [rax]",
			"pop si",
			"pop word ptr [rax]",
			"pop rsi",
			"pop qword ptr [rax]",
			"xchg ax, ax",
			"xchg r8w, ax",
			"nop",
			"xchg r8d, eax",
			"xchg rax, rax",
			"xchg r8, rax",
			"xchg cx, ax",
			"xchg r9w, ax",
			"xchg ecx, eax",
			"xchg r9d, eax",
			"xchg rcx, rax",
			"xchg r9, rax",
			"xchg dx, ax",
			"xchg r10w, ax",
			"xchg edx, eax",
			"xchg r10d, eax",
			"xchg rdx, rax",
			"xchg r10, rax",
			"xchg bx, ax",
			"xchg r11w, ax",
			"xchg ebx, eax",
			"xchg r11d, eax",
			"xchg rbx, rax",
			"xchg r11, rax",
			"xchg sp, ax",
			"xchg r12w, ax",
			"xchg esp, eax",
			"xchg r12d, eax",
			"xchg rsp, rax",
			"xchg r12, rax",
			"xchg bp, ax",
			"xchg r13w, ax",
			"xchg ebp, eax",
			"xchg r13d, eax",
			"xchg rbp, rax",
			"xchg r13, rax",
			"xchg si, ax",
			"xchg r14w, ax",
			"xchg esi, eax",
			"xchg r14d, eax",
			"xchg rsi, rax",
			"xchg r14, rax",
			"xchg di, ax",
			"xchg r15w, ax",
			"xchg edi, eax",
			"xchg r15d, eax",
			"xchg rdi, rax",
			"xchg r15, rax",
			"pause",
			"cbw",
			"cwde",
			"cdqe",
			"cwd",
			"cdq",
			"cqo",
			"fwait",
			"pushf",
			"pushfq",
			"popf",
			"popfq",
			"sahf",
			"lahf",
			"mov al, byte ptr [0xf0debc9a78563412]",
			"addr32 mov al, byte ptr [0x78563412]",
			"mov ax, word ptr [0xf0debc9a78563412]",
			"addr32 mov ax, word ptr [0x78563412]",
			"mov eax, dword ptr [0xf0debc9a78563412]",
			"addr32 mov eax, dword ptr [0x78563412]",
			"mov rax, qword ptr [0xf0debc9a78563412]",
			"addr32 mov rax, qword ptr [0x78563412]",
			"mov byte ptr [0xf0debc9a78563412], al",
			"addr32 mov byte ptr [0x78563412], al",
			"mov word ptr [0xf0debc9a78563412], ax",
			"addr32 mov word ptr [0x78563412], ax",
			"mov dword ptr [0xf0debc9a78563412], eax",
			"addr32 mov dword ptr [0x78563412], eax",
			"mov qword ptr [0xf0debc9a78563412], rax",
			"addr32 mov qword ptr [0x78563412], rax",
			"movsb byte ptr [edi], byte ptr [esi]",
			"movsb byte ptr [rdi], byte ptr [rsi]",
			"movsw word ptr [edi], word ptr [esi]",
			"movsw word ptr [rdi], word ptr [rsi]",
			"movsd dword ptr [edi], dword ptr [esi]",
			"movsd dword ptr [rdi], dword ptr [rsi]",
			"movsq qword ptr [edi], qword ptr [esi]",
			"movsq qword ptr [rdi], qword ptr [rsi]",
			"cmpsb byte ptr [esi], byte ptr [edi]",
			"cmpsb byte ptr [rsi], byte ptr [rdi]",
			"cmpsw word ptr [esi], word ptr [edi]",
			"cmpsw word ptr [rsi], word ptr [rdi]",
			"cmpsd dword ptr [esi], dword ptr [edi]",
			"cmpsd dword ptr [rsi], dword ptr [rdi]",
			"cmpsq qword ptr [esi], qword ptr [edi]",
			"cmpsq qword ptr [rsi], qword ptr [rdi]",
			"test al, -0x5b",
			"test ax, 0x5aa5",
			"test eax, 0x12345aa5",
			"test rax, -0x7dcba55b",
			"stosb byte ptr [edi]",
			"stosb byte ptr [rdi]",
			"stosw word ptr [edi]",
			"stosw word ptr [rdi]",
			"stosd dword ptr [edi]",
			"stosd dword ptr [rdi]",
			"stosq qword ptr [edi]",
			"stosq qword ptr [rdi]",
			"lodsb byte ptr [esi]",
			"lodsb byte ptr [rsi]",
			"lodsw word ptr [esi]",
			"lodsw word ptr [rsi]",
			"lodsd dword ptr [esi]",
			"lodsd dword ptr [rsi]",
			"lodsq qword ptr [esi]",
			"lodsq qword ptr [rsi]",
			"scasb byte ptr [edi]",
			"scasb byte ptr [rdi]",
			"scasw word ptr [edi]",
			"scasw word ptr [rdi]",
			"scasd dword ptr [edi]",
			"scasd dword ptr [rdi]",
			"scasq qword ptr [edi]",
			"scasq qword ptr [rdi]",
			"mov al, 0x5a",
			"mov r8b, 0x5a",
			"mov cl, -0x5b",
			"mov r9b, -0x5b",
			"mov dl, 0x5a",
			"mov r10b, 0x5a",
			"mov bl, -0x5b",
			"mov r11b, -0x5b",
			"mov ah, 0x5a",
			"mov spl, 0x5a",
			"mov r12b, 0x5a",
			"mov ch, -0x5b",
			"mov bpl, -0x5b",
			"mov r13b, -0x5b",
			"mov dh, 0x5a",
			"mov sil, 0x5a",
			"mov r14b, 0x5a",
			"mov bh, -0x5b",
			"mov dil, -0x5b",
			"mov r15b, -0x5b",
			"mov ax, -0x5aa6",
			"mov r8w, -0x5aa6",
			"mov eax, 0x3412a55a",
			"mov r8d, 0x3412a55a",
			"mov rax, 0x3412a55a37261504",
			"mov r8, 0x3412a55a37261504",
			"mov cx, 0x5aa5",
			"mov r9w, 0x5aa5",
			"mov ecx, 0x78565aa5",
			"mov r9d, 0x78565aa5",
			"mov rcx, 0x78565aa537261504",
			"mov r9, 0x78565aa537261504",
			"mov dx, -0x5aa6",
			"mov r10w, -0x5aa6",
			"mov edx, 0x3412a55a",
			"mov r10d, 0x3412a55a",
			"mov rdx, 0x3412a55a37261504",
			"mov r10, 0x3412a55a37261504",
			"mov bx, 0x5aa5",
			"mov r11w, 0x5aa5",
			"mov ebx, 0x78565aa5",
			"mov r11d, 0x78565aa5",
			"mov rbx, 0x78565aa537261504",
			"mov r11, 0x78565aa537261504",
			"mov sp, -0x5aa6",
			"mov r12w, -0x5aa6",
			"mov esp, 0x3412a55a",
			"mov r12d, 0x3412a55a",
			"mov rsp, 0x3412a55a37261504",
			"mov r12, 0x3412a55a37261504",
			"mov bp, 0x5aa5",
			"mov r13w, 0x5aa5",
			"mov ebp, 0x78565aa5",
			"mov r13d, 0x78565aa5",
			"mov rbp, 0x78565aa537261504",
			"mov r13, 0x78565aa537261504",
			"mov si, -0x5aa6",
			"mov r14w, -0x5aa6",
			"mov esi, 0x3412a55a",
			"mov r14d, 0x3412a55a",
			"mov rsi, 0x3412a55a37261504",
			"mov r14, 0x3412a55a37261504",
			"mov di, 0x5aa5",
			"mov r15w, 0x5aa5",
			"mov edi, 0x78565aa5",
			"mov r15d, 0x78565aa5",
			"mov rdi, 0x78565aa537261504",
			"mov r15, 0x78565aa537261504",
			"rol cl, 0x5a",
			"rol byte ptr [rax], 0x5a",
			"ror dl, -0x5b",
			"ror byte ptr [rax], -0x5b",
			"rcl bl, 0x5a",
			"rcl byte ptr [rax], 0x5a",
			"rcr ah, -0x5b",
			"rcr byte ptr [rax], -0x5b",
			"shl ch, 0x5a",
			"shl byte ptr [rax], 0x5a",
			"shr dh, -0x5b",
			"shr byte ptr [rax], -0x5b",
			"sar al, -0x5b",
			"sar byte ptr [rax], -0x5b",
			"rol cx, 0x5a",
			"rol word ptr [rax], 0x5a",
			"rol ecx, 0x5a",
			"rol dword ptr [rax], 0x5a",
			"rol rcx, 0x5a",
			"rol qword ptr [rax], 0x5a",
			"ror dx, -0x5b",
			"ror word ptr [rax], -0x5b",
			"ror edx, -0x5b",
			"ror dword ptr [rax], -0x5b",
			"ror rdx, -0x5b",
			"ror qword ptr [rax], -0x5b",
			"rcl bx, 0x5a",
			"rcl word ptr [rax], 0x5a",
			"rcl ebx, 0x5a",
			"rcl dword ptr [rax], 0x5a",
			"rcl rbx, 0x5a",
			"rcl qword ptr [rax], 0x5a",
			"rcr sp, -0x5b",
			"rcr word ptr [rax], -0x5b",
			"rcr esp, -0x5b",
			"rcr dword ptr [rax], -0x5b",
			"rcr rsp, -0x5b",
			"rcr qword ptr [rax], -0x5b",
			"shl bp, 0x5a",
			"shl word ptr [rax], 0x5a",
			"shl ebp, 0x5a",
			"shl dword ptr [rax], 0x5a",
			"shl rbp, 0x5a",
			"shl qword ptr [rax], 0x5a",
			"shr si, -0x5b",
			"shr word ptr [rax], -0x5b",
			"shr esi, -0x5b",
			"shr dword ptr [rax], -0x5b",
			"shr rsi, -0x5b",
			"shr qword ptr [rax], -0x5b",
			"sar ax, -0x5b",
			"sar word ptr [rax], -0x5b",
			"sar eax, -0x5b",
			"sar dword ptr [rax], -0x5b",
			"sar r8, -0x5b",
			"sar qword ptr [rax], -0x5b",
			"ret -0x5aa6",
			"ret",
			"mov cl, 0x5a",
			"mov byte ptr [rax], 0x5a",
			"xabort 0x5a",
			"mov cx, -0x5aa6",
			"mov word ptr [rax], -0x5aa6",
			"mov ecx, 0x3412a55a",
			"mov dword ptr [rax], 0x3412a55a",
			"mov rcx, -0x7bed5aa6",
			"mov qword ptr [rax], -0x7bed5aa6",
			"data16 xbegin 0x7fffffffffffa54f",
			"xbegin 0x800000003412a550",
			"data64 xbegin 0x800000003412a551",
			"data16 enter -0x5aa6, -0x5a",
			"enter -0x5aa6, -0x5a",
			"data16 leave",
			"leave",
			"data16 ret far -0x5aa6",
			"data32 ret far -0x5aa6",
			"data64 ret far -0x5aa6",
			"data16 ret far",
			"data32 ret far",
			"data64 ret far",
			"int3",
			"int 0x5a",
			"iret",
			"iretd",
			"iretq",
			"rol cl, 1",
			"rol byte ptr [rax], 1",
			"ror dl, 1",
			"ror byte ptr [rax], 1",
			"rcl bl, 1",
			"rcl byte ptr [rax], 1",
			"rcr ah, 1",
			"rcr byte ptr [rax], 1",
			"shl ch, 1",
			"shl byte ptr [rax], 1",
			"shr dh, 1",
			"shr byte ptr [rax], 1",
			"sar al, 1",
			"sar byte ptr [rax], 1",
			"rol cx, 1",
			"rol word ptr [rax], 1",
			"rol ecx, 1",
			"rol dword ptr [rax], 1",
			"rol rcx, 1",
			"rol qword ptr [rax], 1",
			"ror dx, 1",
			"ror word ptr [rax], 1",
			"ror edx, 1",
			"ror dword ptr [rax], 1",
			"ror rdx, 1",
			"ror qword ptr [rax], 1",
			"rcl bx, 1",
			"rcl word ptr [rax], 1",
			"rcl ebx, 1",
			"rcl dword ptr [rax], 1",
			"rcl rbx, 1",
			"rcl qword ptr [rax], 1",
			"rcr sp, 1",
			"rcr word ptr [rax], 1",
			"rcr esp, 1",
			"rcr dword ptr [rax], 1",
			"rcr rsp, 1",
			"rcr qword ptr [rax], 1",
			"shl bp, 1",
			"shl word ptr [rax], 1",
			"shl ebp, 1",
			"shl dword ptr [rax], 1",
			"shl rbp, 1",
			"shl qword ptr [rax], 1",
			"shr si, 1",
			"shr word ptr [rax], 1",
			"shr esi, 1",
			"shr dword ptr [rax], 1",
			"shr rsi, 1",
			"shr qword ptr [rax], 1",
			"sar ax, 1",
			"sar word ptr [rax], 1",
			"sar eax, 1",
			"sar dword ptr [rax], 1",
			"sar r8, 1",
			"sar qword ptr [rax], 1",
			"rol cl, cl",
			"rol byte ptr [rax], cl",
			"ror dl, cl",
			"ror byte ptr [rax], cl",
			"rcl bl, cl",
			"rcl byte ptr [rax], cl",
			"rcr ah, cl",
			"rcr byte ptr [rax], cl",
			"shl ch, cl",
			"shl byte ptr [rax], cl",
			"shr dh, cl",
			"shr byte ptr [rax], cl",
			"sar al, cl",
			"sar byte ptr [rax], cl",
			"rol cx, cl",
			"rol word ptr [rax], cl",
			"rol ecx, cl",
			"rol dword ptr [rax], cl",
			"rol rcx, cl",
			"rol qword ptr [rax], cl",
			"ror dx, cl",
			"ror word ptr [rax], cl",
			"ror edx, cl",
			"ror dword ptr [rax], cl",
			"ror rdx, cl",
			"ror qword ptr [rax], cl",
			"rcl bx, cl",
			"rcl word ptr [rax], cl",
			"rcl ebx, cl",
			"rcl dword ptr [rax], cl",
			"rcl rbx, cl",
			"rcl qword ptr [rax], cl",
			"rcr sp, cl",
			"rcr word ptr [rax], cl",
			"rcr esp, cl",
			"rcr dword ptr [rax], cl",
			"rcr rsp, cl",
			"rcr qword ptr [rax], cl",
			"shl bp, cl",
			"shl word ptr [rax], cl",
			"shl ebp, cl",
			"shl dword ptr [rax], cl",
			"shl rbp, cl",
			"shl qword ptr [rax], cl",
			"shr si, cl",
			"shr word ptr [rax], cl",
			"shr esi, cl",
			"shr dword ptr [rax], cl",
			"shr rsi, cl",
			"shr qword ptr [rax], cl",
			"sar ax, cl",
			"sar word ptr [rax], cl",
			"sar eax, cl",
			"sar dword ptr [rax], cl",
			"sar r8, cl",
			"sar qword ptr [rax], cl",
			"xlat byte ptr [rbx]",
			"fadd st, dword ptr [rax]",
			"fmul st, dword ptr [rax]",
			"fcom st, dword ptr [rax]",
			"fcomp st, dword ptr [rax]",
			"fsub st, dword ptr [rax]",
			"fsubr st, dword ptr [rax]",
			"fdiv st, dword ptr [rax]",
			"fdivr st, dword ptr [rax]",
			"fadd st, st(3)",
			"fmul st, st(3)",
			"fcom st, st(3)",
			"fcomp st, st(3)",
			"fsub st, st(3)",
			"fsubr st, st(3)",
			"fdiv st, st(3)",
			"fdivr st, st(3)",
			"fld st, dword ptr [rax]",
			"fst dword ptr [rax], st",
			"fstp dword ptr [rax], st",
			"fldenv fpuenv14 ptr [rax]",
			"fldenv [rax]",
			"fldcw word ptr [rax]",
			"fnstenv fpuenv14 ptr [rax]",
			"fnstenv [rax]",
			"fnstcw word ptr [rax]",
			"fld st, st(3)",
			"fxch st, st(3)",
			"fnop",
			"fchs",
			"fabs",
			"ftst",
			"fxam",
			"fld1",
			"fldl2t",
			"fldl2e",
			"fldpi",
			"fldlg2",
			"fldln2",
			"fldz",
			"f2xm1",
			"fyl2x",
			"fptan",
			"fpatan",
			"fxtract",
			"fprem1",
			"fdecstp",
			"fincstp",
			"fprem",
			"fyl2xp1",
			"fsqrt",
			"fsincos",
			"frndint",
			"fscale",
			"fsin",
			"fcos",
			"fiadd st, dword ptr [rax]",
			"fimul st, dword ptr [rax]",
			"ficom st, dword ptr [rax]",
			"ficomp st, dword ptr [rax]",
			"fisub st, dword ptr [rax]",
			"fisubr st, dword ptr [rax]",
			"fidiv st, dword ptr [rax]",
			"fidivr st, dword ptr [rax]",
			"fcmovb st, st(3)",
			"fcmove st, st(3)",
			"fcmovbe st, st(3)",
			"fcmovu st, st(3)",
			"fucompp",
			"fild st, dword ptr [rax]",
			"fisttp dword ptr [rax], st",
			"fist dword ptr [rax], st",
			"fistp dword ptr [rax], st",
			"fld st, tbyte ptr [rax]",
			"fstp tbyte ptr [rax], st",
			"fcmovnb st, st(3)",
			"fcmovne st, st(3)",
			"fcmovnbe st, st(3)",
			"fcmovnu st, st(3)",
			"fnclex",
			"fninit",
			"fucomi st, st(3)",
			"fcomi st, st(3)",
			"fadd st, qword ptr [rax]",
			"fmul st, qword ptr [rax]",
			"fcom st, qword ptr [rax]",
			"fcomp st, qword ptr [rax]",
			"fsub st, qword ptr [rax]",
			"fsubr st, qword ptr [rax]",
			"fdiv st, qword ptr [rax]",
			"fdivr st, qword ptr [rax]",
			"fadd st(3), st",
			"fmul st(3), st",
			"fsubr st(3), st",
			"fsub st(3), st",
			"fdivr st(3), st",
			"fdiv st(3), st",
			"fld st, qword ptr [rax]",
			"fisttp qword ptr [rax], st",
			"fst qword ptr [rax], st",
			"fstp qword ptr [rax], st",
			"frstor fpustate98 ptr [rax]",
			"frstor [rax]",
			"fnsave fpustate98 ptr [rax]",
			"fnsave [rax]",
			"fnstsw word ptr [rax]",
			"ffree st(3)",
			"fst st(3), st",
			"fstp st(3), st",
			"fucom st, st(3)",
			"fucomp st, st(3)",
			"fiadd st, word ptr [rax]",
			"fimul st, word ptr [rax]",
			"ficom st, word ptr [rax]",
			"ficomp st, word ptr [rax]",
			"fisub st, word ptr [rax]",
			"fisubr st, word ptr [rax]",
			"fidiv st, word ptr [rax]",
			"fidivr st, word ptr [rax]",
			"faddp st(3), st",
			"fmulp st(3), st",
			"fcompp",
			"fsubrp st(3), st",
			"fsubp st(3), st",
			"fdivrp st(3), st",
			"fdivp st(3), st",
			"fild st, word ptr [rax]",
			"fisttp word ptr [rax], st",
			"fist word ptr [rax], st",
			"fistp word ptr [rax], st",
			"fbld st, tbyte ptr [rax]",
			"fild st, qword ptr [rax]",
			"fbstp tbyte ptr [rax], st",
			"fistp qword ptr [rax], st",
			"fnstsw ax",
			"fucomip st, st(3)",
			"fcomip st, st(3)",
			"addr32 loopne 0x800000000000004d",
			"loopne 0x800000000000004c",
			"addr32 loope 0x800000000000004d",
			"loope 0x800000000000004c",
			"addr32 loop 0x800000000000004d",
			"loop 0x800000000000004c",
			"jecxz 0x800000000000004d",
			"jrcxz 0x800000000000004c",
			"in al, 0x5a",
			"in ax, 0x5a",
			"in eax, 0x5a",
			"out 0x5a, al",
			"out 0x5a, ax",
			"out 0x5a, eax",
			"call 0x7fffffffa55a3407",
			"jmp 0x7fffffffa55a3407",
			"jmp short 0x800000000000004c",
			"in al, dx",
			"in ax, dx",
			"in eax, dx",
			"out dx, al",
			"out dx, ax",
			"out dx, eax",
			"int1",
			"hlt",
			"cmc",
			"test cl, 0x5a",
			"test byte ptr [rax], 0x5a",
			"not cl",
			"not byte ptr [rax]",
			"neg dh",
			"neg byte ptr [rax]",
			"mul ch",
			"mul byte ptr [rax]",
			"imul dh",
			"imul byte ptr [rax]",
			"div bh",
			"div byte ptr [rax]",
			"idiv al",
		};
	}
}
#endif
