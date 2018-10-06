﻿namespace hjudgeCore
{
    public enum WindowsExceptionCode : uint
    {
        EXCEPTION_ACCESS_VIOLATION = 0xC0000005,
        EXCEPTION_ARRAY_BOUNDS_EXCEEDED = 0xC000008C,
        EXCEPTION_BREAKPOINT = 0x80000003,
        EXCEPTION_DATATYPE_MISALIGNMENT = 0x80000002,
        EXCEPTION_FLT_DENORMAL_OPERAND = 0xC000008D,
        EXCEPTION_FLT_DIVIDE_BY_ZERO = 0xC000008E,
        EXCEPTION_FLT_INEXACT_RESULT = 0xC000008F,
        EXCEPTION_FLT_INVALID_OPERATION = 0xC0000090,
        EXCEPTION_FLT_OVERFLOW = 0xC0000091,
        EXCEPTION_FLT_STACK_CHECK = 0xC0000092,
        EXCEPTION_FLT_UNDERFLOW = 0xC0000093,
        EXCEPTION_ILLEGAL_INSTRUCTION = 0xC000001D,
        EXCEPTION_IN_PAGE_ERROR = 0xC0000006,
        EXCEPTION_INT_DIVIDE_BY_ZERO = 0xC0000094,
        EXCEPTION_INT_OVERFLOW = 0xC0000095,
        EXCEPTION_INVALID_DISPOSITION = 0xC0000026,
        EXCEPTION_NONCONTINUABLE_EXCEPTION = 0xC0000025,
        EXCEPTION_PRIV_INSTRUCTION = 0xC0000096,
        EXCEPTION_SINGLE_STEP = 0x80000004,
        EXCEPTION_STACK_OVERFLOW = 0xC00000FD
    }
}