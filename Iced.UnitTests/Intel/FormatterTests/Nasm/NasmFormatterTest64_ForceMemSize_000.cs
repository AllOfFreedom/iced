/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_NASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Nasm {
	public sealed class NasmFormatterTest64_ForceMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_000.AllInfos_Length] {
			"add dh,cl",
			"add byte [rax],bh",
			"add si,cx",
			"add word [rax],bx",
			"add esi,ecx",
			"add dword [rax],ebx",
			"add rsi,rcx",
			"add qword [rax],rbx",
			"add cl,dh",
			"add bh,byte [rax]",
			"add cx,si",
			"add bx,word [rax]",
			"add ecx,esi",
			"add ebx,dword [rax]",
			"add rcx,rsi",
			"add rbx,qword [rax]",
			"add al,-0x5b",
			"add ax,0x5aa5",
			"add eax,0x12345aa5",
			"add rax,qword -0x7dcba55b",
			"or dh,cl",
			"or byte [rax],bh",
			"or si,cx",
			"or word [rax],bx",
			"or esi,ecx",
			"or dword [rax],ebx",
			"or rsi,rcx",
			"or qword [rax],rbx",
			"or cl,dh",
			"or bh,byte [rax]",
			"or cx,si",
			"or bx,word [rax]",
			"or ecx,esi",
			"or ebx,dword [rax]",
			"or rcx,rsi",
			"or rbx,qword [rax]",
			"or al,-0x5b",
			"or ax,0x5aa5",
			"or eax,0x12345aa5",
			"or rax,qword -0x7dcba55b",
			"adc dh,cl",
			"adc byte [rax],bh",
			"adc si,cx",
			"adc word [rax],bx",
			"adc esi,ecx",
			"adc dword [rax],ebx",
			"adc rsi,rcx",
			"adc qword [rax],rbx",
			"adc cl,dh",
			"adc bh,byte [rax]",
			"adc cx,si",
			"adc bx,word [rax]",
			"adc ecx,esi",
			"adc ebx,dword [rax]",
			"adc rcx,rsi",
			"adc rbx,qword [rax]",
			"adc al,-0x5b",
			"adc ax,0x5aa5",
			"adc eax,0x12345aa5",
			"adc rax,qword -0x7dcba55b",
			"sbb dh,cl",
			"sbb byte [rax],bh",
			"sbb si,cx",
			"sbb word [rax],bx",
			"sbb esi,ecx",
			"sbb dword [rax],ebx",
			"sbb rsi,rcx",
			"sbb qword [rax],rbx",
			"sbb cl,dh",
			"sbb bh,byte [rax]",
			"sbb cx,si",
			"sbb bx,word [rax]",
			"sbb ecx,esi",
			"sbb ebx,dword [rax]",
			"sbb rcx,rsi",
			"sbb rbx,qword [rax]",
			"sbb al,-0x5b",
			"sbb ax,0x5aa5",
			"sbb eax,0x12345aa5",
			"sbb rax,qword -0x7dcba55b",
			"and dh,cl",
			"and byte [rax],bh",
			"and si,cx",
			"and word [rax],bx",
			"and esi,ecx",
			"and dword [rax],ebx",
			"and rsi,rcx",
			"and qword [rax],rbx",
			"and cl,dh",
			"and bh,byte [rax]",
			"and cx,si",
			"and bx,word [rax]",
			"and ecx,esi",
			"and ebx,dword [rax]",
			"and rcx,rsi",
			"and rbx,qword [rax]",
			"and al,-0x5b",
			"and ax,0x5aa5",
			"and eax,0x12345aa5",
			"and rax,qword -0x7dcba55b",
			"sub dh,cl",
			"sub byte [rax],bh",
			"sub si,cx",
			"sub word [rax],bx",
			"sub esi,ecx",
			"sub dword [rax],ebx",
			"sub rsi,rcx",
			"sub qword [rax],rbx",
			"sub cl,dh",
			"sub bh,byte [rax]",
			"sub cx,si",
			"sub bx,word [rax]",
			"sub ecx,esi",
			"sub ebx,dword [rax]",
			"sub rcx,rsi",
			"sub rbx,qword [rax]",
			"sub al,-0x5b",
			"sub ax,0x5aa5",
			"sub eax,0x12345aa5",
			"sub rax,qword -0x7dcba55b",
			"xor dh,cl",
			"xor byte [rax],bh",
			"xor si,cx",
			"xor word [rax],bx",
			"xor esi,ecx",
			"xor dword [rax],ebx",
			"xor rsi,rcx",
			"xor qword [rax],rbx",
			"xor cl,dh",
			"xor bh,byte [rax]",
			"xor cx,si",
			"xor bx,word [rax]",
			"xor ecx,esi",
			"xor ebx,dword [rax]",
			"xor rcx,rsi",
			"xor rbx,qword [rax]",
			"xor al,-0x5b",
			"xor ax,0x5aa5",
			"xor eax,0x12345aa5",
			"xor rax,qword -0x7dcba55b",
			"cmp dh,cl",
			"cmp byte [rax],bh",
			"cmp si,cx",
			"cmp word [rax],bx",
			"cmp esi,ecx",
			"cmp dword [rax],ebx",
			"cmp rsi,rcx",
			"cmp qword [rax],rbx",
			"cmp cl,dh",
			"cmp bh,byte [rax]",
			"cmp cx,si",
			"cmp bx,word [rax]",
			"cmp ecx,esi",
			"cmp ebx,dword [rax]",
			"cmp rcx,rsi",
			"cmp rbx,qword [rax]",
			"cmp al,-0x5b",
			"cmp ax,0x5aa5",
			"cmp eax,0x12345aa5",
			"cmp rax,qword -0x7dcba55b",
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
			"movsxd cx,si",
			"movsxd bx,word [rax]",
			"movsxd ecx,esi",
			"movsxd ebx,dword [rax]",
			"movsxd rcx,esi",
			"movsxd rbx,dword [rax]",
			"o16 push word -0x5aa6",
			"push qword -0x7bed5aa6",
			"imul cx,si,word 0x5aa5",
			"imul bx,word [rax],word -0x5aa6",
			"imul ecx,esi,dword 0x3412a55a",
			"imul ebx,dword [rax],dword 0x3412a55a",
			"imul rcx,rsi,qword -0x7bed5aa6",
			"imul rbx,qword [rax],qword -0x7bed5aa6",
			"o16 push byte -0x5b",
			"push byte -0x5b",
			"imul cx,si,byte -0x5b",
			"imul bx,word [rax],byte -0x5b",
			"imul ecx,esi,byte -0x5b",
			"imul ebx,dword [rax],byte -0x5b",
			"imul rcx,rsi,byte -0x5b",
			"imul rbx,qword [rax],byte -0x5b",
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
			"add cl,0x5a",
			"add byte [rax],0x5a",
			"or dl,-0x5b",
			"or byte [rax],-0x5b",
			"adc bl,0x5a",
			"adc byte [rax],0x5a",
			"sbb ah,-0x5b",
			"sbb byte [rax],-0x5b",
			"and ch,0x5a",
			"and byte [rax],0x5a",
			"sub dh,-0x5b",
			"sub byte [rax],-0x5b",
			"xor bh,0x5a",
			"xor byte [rax],0x5a",
			"cmp al,-0x5b",
			"cmp byte [rax],-0x5b",
			"add cx,-0x5aa6",
			"add word [rax],-0x5aa6",
			"add ecx,0x3412a55a",
			"add dword [rax],0x3412a55a",
			"add rcx,qword -0x7bed5aa6",
			"add qword [rax],qword -0x7bed5aa6",
			"or dx,0x5aa5",
			"or word [rax],0x5aa5",
			"or edx,-0x5476a55b",
			"or dword [rax],-0x5476a55b",
			"or rdx,qword -0x7bed5aa6",
			"or qword [rax],qword -0x7bed5aa6",
			"adc bx,-0x5aa6",
			"adc word [rax],-0x5aa6",
			"adc ebx,0x3412a55a",
			"adc dword [rax],0x3412a55a",
			"adc rbx,qword -0x7bed5aa6",
			"adc qword [rax],qword -0x7bed5aa6",
			"sbb sp,0x5aa5",
			"sbb word [rax],0x5aa5",
			"sbb esp,-0x5476a55b",
			"sbb dword [rax],-0x5476a55b",
			"sbb rsp,qword -0x7bed5aa6",
			"sbb qword [rax],qword -0x7bed5aa6",
			"and bp,-0x5aa6",
			"and word [rax],-0x5aa6",
			"and ebp,0x3412a55a",
			"and dword [rax],0x3412a55a",
			"and rbp,qword -0x7bed5aa6",
			"and qword [rax],qword -0x7bed5aa6",
			"sub si,0x5aa5",
			"sub word [rax],0x5aa5",
			"sub esi,-0x5476a55b",
			"sub dword [rax],-0x5476a55b",
			"sub rsi,qword -0x7bed5aa6",
			"sub qword [rax],qword -0x7bed5aa6",
			"xor di,-0x5aa6",
			"xor word [rax],-0x5aa6",
			"xor edi,0x3412a55a",
			"xor dword [rax],0x3412a55a",
			"xor rdi,qword -0x7bed5aa6",
			"xor qword [rax],qword -0x7bed5aa6",
			"cmp ax,0x5aa5",
			"cmp word [rax],0x5aa5",
			"cmp eax,-0x5476a55b",
			"cmp dword [rax],-0x5476a55b",
			"cmp r8,qword -0x7bed5aa6",
			"cmp qword [rax],qword -0x7bed5aa6",
			"add cx,byte -0x5b",
			"add word [rax],byte -0x5b",
			"add ecx,byte -0x5b",
			"add dword [rax],byte -0x5b",
			"add rcx,byte -0x5b",
			"add qword [rax],byte -0x5b",
			"or dx,byte -0x5b",
			"or word [rax],byte -0x5b",
			"or edx,byte -0x5b",
			"or dword [rax],byte -0x5b",
			"or rdx,byte -0x5b",
			"or qword [rax],byte -0x5b",
			"adc bx,byte -0x5b",
			"adc word [rax],byte -0x5b",
			"adc ebx,byte -0x5b",
			"adc dword [rax],byte -0x5b",
			"adc rbx,byte -0x5b",
			"adc qword [rax],byte -0x5b",
			"sbb sp,byte -0x5b",
			"sbb word [rax],byte -0x5b",
			"sbb esp,byte -0x5b",
			"sbb dword [rax],byte -0x5b",
			"sbb rsp,byte -0x5b",
			"sbb qword [rax],byte -0x5b",
			"and bp,byte -0x5b",
			"and word [rax],byte -0x5b",
			"and ebp,byte -0x5b",
			"and dword [rax],byte -0x5b",
			"and rbp,byte -0x5b",
			"and qword [rax],byte -0x5b",
			"sub si,byte -0x5b",
			"sub word [rax],byte -0x5b",
			"sub esi,byte -0x5b",
			"sub dword [rax],byte -0x5b",
			"sub rsi,byte -0x5b",
			"sub qword [rax],byte -0x5b",
			"xor di,byte -0x5b",
			"xor word [rax],byte -0x5b",
			"xor edi,byte -0x5b",
			"xor dword [rax],byte -0x5b",
			"xor rdi,byte -0x5b",
			"xor qword [rax],byte -0x5b",
			"cmp ax,byte -0x5b",
			"cmp word [rax],byte -0x5b",
			"cmp eax,byte -0x5b",
			"cmp dword [rax],byte -0x5b",
			"cmp r8,byte -0x5b",
			"cmp qword [rax],byte -0x5b",
			"test dh,cl",
			"test byte [rax],bh",
			"test si,cx",
			"test word [rax],bx",
			"test esi,ecx",
			"test dword [rax],ebx",
			"test rsi,rcx",
			"test qword [rax],rbx",
			"xchg cl,dh",
			"xchg bh,byte [rax]",
			"xchg cx,si",
			"xchg bx,word [rax]",
			"xchg ecx,esi",
			"xchg ebx,dword [rax]",
			"xchg rcx,rsi",
			"xchg rbx,qword [rax]",
			"mov dh,cl",
			"mov byte [rax],bh",
			"mov si,cx",
			"mov word [rax],bx",
			"mov esi,ecx",
			"mov dword [rax],ebx",
			"mov rsi,rcx",
			"mov qword [rax],rbx",
			"mov cl,dh",
			"mov bh,byte [rax]",
			"mov cx,si",
			"mov bx,word [rax]",
			"mov ecx,esi",
			"mov ebx,dword [rax]",
			"mov rcx,rsi",
			"mov rbx,qword [rax]",
			"mov si,cs",
			"o16 mov word [rax],ds",
			"mov esi,cs",
			"mov word [rax],ds",
			"mov rsi,cs",
			"o64 mov word [rax],ds",
			"lea bx,[rax]",
			"lea ebx,[rax]",
			"lea rbx,[rax]",
			"mov fs,si",
			"o16 mov ds,word [rax]",
			"mov fs,esi",
			"mov ds,word [rax]",
			"mov fs,rsi",
			"o64 mov ds,word [rax]",
			"pop si",
			"pop word [rax]",
			"pop rsi",
			"pop qword [rax]",
			"xchg ax,ax",
			"xchg r8w,ax",
			"nop",
			"xchg r8d,eax",
			"xchg rax,rax",
			"xchg r8,rax",
			"xchg cx,ax",
			"xchg r9w,ax",
			"xchg ecx,eax",
			"xchg r9d,eax",
			"xchg rcx,rax",
			"xchg r9,rax",
			"xchg dx,ax",
			"xchg r10w,ax",
			"xchg edx,eax",
			"xchg r10d,eax",
			"xchg rdx,rax",
			"xchg r10,rax",
			"xchg bx,ax",
			"xchg r11w,ax",
			"xchg ebx,eax",
			"xchg r11d,eax",
			"xchg rbx,rax",
			"xchg r11,rax",
			"xchg sp,ax",
			"xchg r12w,ax",
			"xchg esp,eax",
			"xchg r12d,eax",
			"xchg rsp,rax",
			"xchg r12,rax",
			"xchg bp,ax",
			"xchg r13w,ax",
			"xchg ebp,eax",
			"xchg r13d,eax",
			"xchg rbp,rax",
			"xchg r13,rax",
			"xchg si,ax",
			"xchg r14w,ax",
			"xchg esi,eax",
			"xchg r14d,eax",
			"xchg rsi,rax",
			"xchg r14,rax",
			"xchg di,ax",
			"xchg r15w,ax",
			"xchg edi,eax",
			"xchg r15d,eax",
			"xchg rdi,rax",
			"xchg r15,rax",
			"pause",
			"cbw",
			"cwde",
			"cdqe",
			"cwd",
			"cdq",
			"cqo",
			"wait",
			"pushfw",
			"pushf",
			"popfw",
			"popf",
			"sahf",
			"lahf",
			"mov al,byte [qword 0xf0debc9a78563412]",
			"a32 mov al,byte [0x78563412]",
			"mov ax,word [qword 0xf0debc9a78563412]",
			"a32 mov ax,word [0x78563412]",
			"mov eax,dword [qword 0xf0debc9a78563412]",
			"a32 mov eax,dword [0x78563412]",
			"mov rax,qword [qword 0xf0debc9a78563412]",
			"a32 mov rax,qword [0x78563412]",
			"mov byte [qword 0xf0debc9a78563412],al",
			"a32 mov byte [0x78563412],al",
			"mov word [qword 0xf0debc9a78563412],ax",
			"a32 mov word [0x78563412],ax",
			"mov dword [qword 0xf0debc9a78563412],eax",
			"a32 mov dword [0x78563412],eax",
			"mov qword [qword 0xf0debc9a78563412],rax",
			"a32 mov qword [0x78563412],rax",
			"a32 movsb",
			"movsb",
			"a32 movsw",
			"movsw",
			"a32 movsd",
			"movsd",
			"a32 movsq",
			"movsq",
			"a32 cmpsb",
			"cmpsb",
			"a32 cmpsw",
			"cmpsw",
			"a32 cmpsd",
			"cmpsd",
			"a32 cmpsq",
			"cmpsq",
			"test al,-0x5b",
			"test ax,0x5aa5",
			"test eax,0x12345aa5",
			"test rax,-0x7dcba55b",
			"a32 stosb",
			"stosb",
			"a32 stosw",
			"stosw",
			"a32 stosd",
			"stosd",
			"a32 stosq",
			"stosq",
			"a32 lodsb",
			"lodsb",
			"a32 lodsw",
			"lodsw",
			"a32 lodsd",
			"lodsd",
			"a32 lodsq",
			"lodsq",
			"a32 scasb",
			"scasb",
			"a32 scasw",
			"scasw",
			"a32 scasd",
			"scasd",
			"a32 scasq",
			"scasq",
			"mov al,0x5a",
			"mov r8b,0x5a",
			"mov cl,-0x5b",
			"mov r9b,-0x5b",
			"mov dl,0x5a",
			"mov r10b,0x5a",
			"mov bl,-0x5b",
			"mov r11b,-0x5b",
			"mov ah,0x5a",
			"mov spl,0x5a",
			"mov r12b,0x5a",
			"mov ch,-0x5b",
			"mov bpl,-0x5b",
			"mov r13b,-0x5b",
			"mov dh,0x5a",
			"mov sil,0x5a",
			"mov r14b,0x5a",
			"mov bh,-0x5b",
			"mov dil,-0x5b",
			"mov r15b,-0x5b",
			"mov ax,-0x5aa6",
			"mov r8w,-0x5aa6",
			"mov eax,0x3412a55a",
			"mov r8d,0x3412a55a",
			"mov rax,0x3412a55a37261504",
			"mov r8,0x3412a55a37261504",
			"mov cx,0x5aa5",
			"mov r9w,0x5aa5",
			"mov ecx,0x78565aa5",
			"mov r9d,0x78565aa5",
			"mov rcx,0x78565aa537261504",
			"mov r9,0x78565aa537261504",
			"mov dx,-0x5aa6",
			"mov r10w,-0x5aa6",
			"mov edx,0x3412a55a",
			"mov r10d,0x3412a55a",
			"mov rdx,0x3412a55a37261504",
			"mov r10,0x3412a55a37261504",
			"mov bx,0x5aa5",
			"mov r11w,0x5aa5",
			"mov ebx,0x78565aa5",
			"mov r11d,0x78565aa5",
			"mov rbx,0x78565aa537261504",
			"mov r11,0x78565aa537261504",
			"mov sp,-0x5aa6",
			"mov r12w,-0x5aa6",
			"mov esp,0x3412a55a",
			"mov r12d,0x3412a55a",
			"mov rsp,0x3412a55a37261504",
			"mov r12,0x3412a55a37261504",
			"mov bp,0x5aa5",
			"mov r13w,0x5aa5",
			"mov ebp,0x78565aa5",
			"mov r13d,0x78565aa5",
			"mov rbp,0x78565aa537261504",
			"mov r13,0x78565aa537261504",
			"mov si,-0x5aa6",
			"mov r14w,-0x5aa6",
			"mov esi,0x3412a55a",
			"mov r14d,0x3412a55a",
			"mov rsi,0x3412a55a37261504",
			"mov r14,0x3412a55a37261504",
			"mov di,0x5aa5",
			"mov r15w,0x5aa5",
			"mov edi,0x78565aa5",
			"mov r15d,0x78565aa5",
			"mov rdi,0x78565aa537261504",
			"mov r15,0x78565aa537261504",
			"rol cl,0x5a",
			"rol byte [rax],0x5a",
			"ror dl,-0x5b",
			"ror byte [rax],-0x5b",
			"rcl bl,0x5a",
			"rcl byte [rax],0x5a",
			"rcr ah,-0x5b",
			"rcr byte [rax],-0x5b",
			"shl ch,0x5a",
			"shl byte [rax],0x5a",
			"shr dh,-0x5b",
			"shr byte [rax],-0x5b",
			"sar al,-0x5b",
			"sar byte [rax],-0x5b",
			"rol cx,0x5a",
			"rol word [rax],0x5a",
			"rol ecx,0x5a",
			"rol dword [rax],0x5a",
			"rol rcx,0x5a",
			"rol qword [rax],0x5a",
			"ror dx,-0x5b",
			"ror word [rax],-0x5b",
			"ror edx,-0x5b",
			"ror dword [rax],-0x5b",
			"ror rdx,-0x5b",
			"ror qword [rax],-0x5b",
			"rcl bx,0x5a",
			"rcl word [rax],0x5a",
			"rcl ebx,0x5a",
			"rcl dword [rax],0x5a",
			"rcl rbx,0x5a",
			"rcl qword [rax],0x5a",
			"rcr sp,-0x5b",
			"rcr word [rax],-0x5b",
			"rcr esp,-0x5b",
			"rcr dword [rax],-0x5b",
			"rcr rsp,-0x5b",
			"rcr qword [rax],-0x5b",
			"shl bp,0x5a",
			"shl word [rax],0x5a",
			"shl ebp,0x5a",
			"shl dword [rax],0x5a",
			"shl rbp,0x5a",
			"shl qword [rax],0x5a",
			"shr si,-0x5b",
			"shr word [rax],-0x5b",
			"shr esi,-0x5b",
			"shr dword [rax],-0x5b",
			"shr rsi,-0x5b",
			"shr qword [rax],-0x5b",
			"sar ax,-0x5b",
			"sar word [rax],-0x5b",
			"sar eax,-0x5b",
			"sar dword [rax],-0x5b",
			"sar r8,-0x5b",
			"sar qword [rax],-0x5b",
			"ret -0x5aa6",
			"ret",
			"mov cl,0x5a",
			"mov byte [rax],0x5a",
			"xabort 0x5a",
			"mov cx,-0x5aa6",
			"mov word [rax],-0x5aa6",
			"mov ecx,0x3412a55a",
			"mov dword [rax],0x3412a55a",
			"mov rcx,dword -0x7bed5aa6",
			"mov qword [rax],qword -0x7bed5aa6",
			"o16 xbegin 0x7fffffffffffa54f",
			"xbegin 0x800000003412a550",
			"o64 xbegin 0x800000003412a551",
			"o16 enter -0x5aa6,-0x5a",
			"enter -0x5aa6,-0x5a",
			"o16 leave",
			"leave",
			"retfw -0x5aa6",
			"retf -0x5aa6",
			"retfq -0x5aa6",
			"retfw",
			"retf",
			"retfq",
			"int3",
			"int 0x5a",
			"iretw",
			"iret",
			"iretq",
			"rol cl,1",
			"rol byte [rax],1",
			"ror dl,1",
			"ror byte [rax],1",
			"rcl bl,1",
			"rcl byte [rax],1",
			"rcr ah,1",
			"rcr byte [rax],1",
			"shl ch,1",
			"shl byte [rax],1",
			"shr dh,1",
			"shr byte [rax],1",
			"sar al,1",
			"sar byte [rax],1",
			"rol cx,1",
			"rol word [rax],1",
			"rol ecx,1",
			"rol dword [rax],1",
			"rol rcx,1",
			"rol qword [rax],1",
			"ror dx,1",
			"ror word [rax],1",
			"ror edx,1",
			"ror dword [rax],1",
			"ror rdx,1",
			"ror qword [rax],1",
			"rcl bx,1",
			"rcl word [rax],1",
			"rcl ebx,1",
			"rcl dword [rax],1",
			"rcl rbx,1",
			"rcl qword [rax],1",
			"rcr sp,1",
			"rcr word [rax],1",
			"rcr esp,1",
			"rcr dword [rax],1",
			"rcr rsp,1",
			"rcr qword [rax],1",
			"shl bp,1",
			"shl word [rax],1",
			"shl ebp,1",
			"shl dword [rax],1",
			"shl rbp,1",
			"shl qword [rax],1",
			"shr si,1",
			"shr word [rax],1",
			"shr esi,1",
			"shr dword [rax],1",
			"shr rsi,1",
			"shr qword [rax],1",
			"sar ax,1",
			"sar word [rax],1",
			"sar eax,1",
			"sar dword [rax],1",
			"sar r8,1",
			"sar qword [rax],1",
			"rol cl,cl",
			"rol byte [rax],cl",
			"ror dl,cl",
			"ror byte [rax],cl",
			"rcl bl,cl",
			"rcl byte [rax],cl",
			"rcr ah,cl",
			"rcr byte [rax],cl",
			"shl ch,cl",
			"shl byte [rax],cl",
			"shr dh,cl",
			"shr byte [rax],cl",
			"sar al,cl",
			"sar byte [rax],cl",
			"rol cx,cl",
			"rol word [rax],cl",
			"rol ecx,cl",
			"rol dword [rax],cl",
			"rol rcx,cl",
			"rol qword [rax],cl",
			"ror dx,cl",
			"ror word [rax],cl",
			"ror edx,cl",
			"ror dword [rax],cl",
			"ror rdx,cl",
			"ror qword [rax],cl",
			"rcl bx,cl",
			"rcl word [rax],cl",
			"rcl ebx,cl",
			"rcl dword [rax],cl",
			"rcl rbx,cl",
			"rcl qword [rax],cl",
			"rcr sp,cl",
			"rcr word [rax],cl",
			"rcr esp,cl",
			"rcr dword [rax],cl",
			"rcr rsp,cl",
			"rcr qword [rax],cl",
			"shl bp,cl",
			"shl word [rax],cl",
			"shl ebp,cl",
			"shl dword [rax],cl",
			"shl rbp,cl",
			"shl qword [rax],cl",
			"shr si,cl",
			"shr word [rax],cl",
			"shr esi,cl",
			"shr dword [rax],cl",
			"shr rsi,cl",
			"shr qword [rax],cl",
			"sar ax,cl",
			"sar word [rax],cl",
			"sar eax,cl",
			"sar dword [rax],cl",
			"sar r8,cl",
			"sar qword [rax],cl",
			"xlatb",
			"fadd dword [rax]",
			"fmul dword [rax]",
			"fcom dword [rax]",
			"fcomp dword [rax]",
			"fsub dword [rax]",
			"fsubr dword [rax]",
			"fdiv dword [rax]",
			"fdivr dword [rax]",
			"fadd st3",
			"fmul st3",
			"fcom st3",
			"fcomp st3",
			"fsub st3",
			"fsubr st3",
			"fdiv st3",
			"fdivr st3",
			"fld dword [rax]",
			"fst dword [rax]",
			"fstp dword [rax]",
			"o16 fldenv [rax]",
			"fldenv [rax]",
			"fldcw word [rax]",
			"o16 fnstenv [rax]",
			"fnstenv [rax]",
			"fnstcw word [rax]",
			"fld st3",
			"fxch st3",
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
			"fiadd dword [rax]",
			"fimul dword [rax]",
			"ficom dword [rax]",
			"ficomp dword [rax]",
			"fisub dword [rax]",
			"fisubr dword [rax]",
			"fidiv dword [rax]",
			"fidivr dword [rax]",
			"fcmovb st3",
			"fcmove st3",
			"fcmovbe st3",
			"fcmovu st3",
			"fucompp",
			"fild dword [rax]",
			"fisttp dword [rax]",
			"fist dword [rax]",
			"fistp dword [rax]",
			"fld tword [rax]",
			"fstp tword [rax]",
			"fcmovnb st3",
			"fcmovne st3",
			"fcmovnbe st3",
			"fcmovnu st3",
			"fnclex",
			"fninit",
			"fucomi st3",
			"fcomi st3",
			"fadd qword [rax]",
			"fmul qword [rax]",
			"fcom qword [rax]",
			"fcomp qword [rax]",
			"fsub qword [rax]",
			"fsubr qword [rax]",
			"fdiv qword [rax]",
			"fdivr qword [rax]",
			"fadd to st3",
			"fmul to st3",
			"fsubr to st3",
			"fsub to st3",
			"fdivr to st3",
			"fdiv to st3",
			"fld qword [rax]",
			"fisttp qword [rax]",
			"fst qword [rax]",
			"fstp qword [rax]",
			"o16 frstor [rax]",
			"frstor [rax]",
			"o16 fnsave [rax]",
			"fnsave [rax]",
			"fnstsw word [rax]",
			"ffree st3",
			"fst st3",
			"fstp st3",
			"fucom st3",
			"fucomp st3",
			"fiadd word [rax]",
			"fimul word [rax]",
			"ficom word [rax]",
			"ficomp word [rax]",
			"fisub word [rax]",
			"fisubr word [rax]",
			"fidiv word [rax]",
			"fidivr word [rax]",
			"faddp st3",
			"fmulp st3",
			"fcompp",
			"fsubrp st3",
			"fsubp st3",
			"fdivrp st3",
			"fdivp st3",
			"fild word [rax]",
			"fisttp word [rax]",
			"fist word [rax]",
			"fistp word [rax]",
			"fbld tword [rax]",
			"fild qword [rax]",
			"fbstp tword [rax]",
			"fistp qword [rax]",
			"fnstsw ax",
			"fucomip st3",
			"fcomip st3",
			"o16 loopne 0x004e,ecx",
			"loopne 0x800000000000004d,ecx",
			"o16 loopne 0x004d",
			"loopne 0x800000000000004c",
			"o16 loope 0x004e,ecx",
			"loope 0x800000000000004d,ecx",
			"o16 loope 0x004d",
			"loope 0x800000000000004c",
			"o16 loop 0x004e,ecx",
			"loop 0x800000000000004d,ecx",
			"o16 loop 0x004d",
			"loop 0x800000000000004c",
			"o16 jecxz 0x004e",
			"jecxz 0x800000000000004d",
			"o16 jrcxz 0x004d",
			"jrcxz 0x800000000000004c",
			"in al,0x5a",
			"in ax,0x5a",
			"in eax,0x5a",
			"out 0x5a,al",
			"out 0x5a,ax",
			"out 0x5a,eax",
			"call 0x7fffffffa55a3407",
			"jmp 0x7fffffffa55a3407",
			"jmp short 0x800000000000004c",
			"in al,dx",
			"in ax,dx",
			"in eax,dx",
			"out dx,al",
			"out dx,ax",
			"out dx,eax",
			"int1",
			"hlt",
			"cmc",
			"test cl,0x5a",
			"test byte [rax],0x5a",
			"not cl",
			"not byte [rax]",
			"neg dh",
			"neg byte [rax]",
			"mul ch",
			"mul byte [rax]",
			"imul dh",
			"imul byte [rax]",
			"div bh",
			"div byte [rax]",
			"idiv al",
		};
	}
}
#endif
