namespace delet 
{
if ( -44 * v244 > 3 )
{
  if ( v243 - v242 > -32
                   * ((__int64)(((unsigned __int64)((-44 * v244) >> 4) >> 59) - 44 * v244) >> 5)
    || v242 - v243 > -32
                   * ((__int64)(((unsigned __int64)((-44 * v244) >> 4) >> 59) - 44 * v244) >> 5) )
  {
    v46 = 32 * v45;
    ((void (__fastcall *)(char *, char *))sub_140022C10)(v242, v243);
 
    v42 += v46;
    _RSI -= v228.m256i_i64[1];
    _RDI -= v228.m256i_i64[1];
 
    __asm { vzeroupper }
    memcpy(_RDI, _RSI, v42);
    __asm
    {
      vxorps  xmm0, xmm0, xmm0
      vxorps  xmm1, xmm1, xmm1
    }
    _RCX = &v249;
    __asm
    {
      vcvtsi2ss xmm0, xmm0, rax
      vcvtsi2ss xmm1, xmm1, rsi
    }
    v52 = v251;
    __asm
    {
      vmovss  dword ptr [rcx+40h], xmm0
      vmovss  dword ptr [rcx+44h], xmm1
    }
    v53 = *v52;
    v228.m256i_i64[0] = (__int64)v52;
    v249 = *(_QWORD *)(v53 + 16);
    v250 = v276;
    sub_140009F50();
    v54 = *(_QWORD *)a2;
    byte_14002D73D = 1;
    v234 = *(_QWORD *)(v54 + 56);
    qword_14002D658 = a2;
    v228.m256i_i64[0] = a2;
    v235 = v276;
    v55 = ((__int64 (__fastcall *)(char **, _QWORD *, void *, __int64))sub_140010F70)(
            &v231,
            v276,
            &unk_140039010,
            1i64);
    v56 = 16i64 * *(_QWORD *)(v55 + 16);
    _RSI = *(char **)(v55 + 8);
    _RDI = *(char **)v55;
    v228.m256i_i64[1] = *(_QWORD *)(v55 + 8);
    if ( v56 < 0x20 )
    {
 
      __asm { vzeroupper }
      memcpy(_RDI, _RSI, v56);
      v62 = ((__int64 (__fastcall *)(char **, _QWORD *, __int64 *, __int64))sub_140010FD0)(
              &v255,
              v276,
              &qword_14002D610,
              1i64);
      v63 = *(_QWORD *)(v62 + 16);
      _RSI = *(char **)(v62 + 8);
      _RDI = *(char **)v62;
      v228.m256i_i64[2] = *(_QWORD *)(v62 + 8);
      v66 = 8 * v63;
      if ( (unsigned __int64)(8 * v63) < 0x20 )
        goto LABEL_45;
      v67 = (__int64)(((unsigned __int64)((-8 * v63) >> 4) >> 59) - 8 * v63) >> 5;
      v68 = 32 * v67;
      v228.m256i_i64[3] = 32 * v67;
      if ( -8 * v63 > 3 )
      {
        if ( _RSI - _RDI > -32
                         * ((__int64)(((unsigned __int64)((-8 * v63) >> 4) >> 59) - 8 * v63) >> 5)
          || _RDI - _RSI > -32
                         * ((__int64)(((unsigned __int64)((-8 * v63) >> 4) >> 59) - 8 * v63) >> 5) )
        {
          v68 = 32 * v67;
          ((void (__fastcall *)(char *, char *))sub_140022C10)(_RDI, _RSI);
 
          v66 = v68 + 8 * v63;
          _RSI -= v228.m256i_i64[3];
          _RDI -= v228.m256i_i64[3];
 
          __asm { vzeroupper }
          memcpy(_RDI, _RSI, v66);
          ((void (__fastcall *)(__int64 *, __int64, __int64, __int64))sub_1400115A0)(
            &v234,
            v228.m256i_i64[0],
            v228.m256i_i64[1],
            v228.m256i_i64[2]);
          v69 = v257;
          _RDI = v255;
          _RSI = v256;
          v72 = 8 * v257;
          if ( (unsigned __int64)(8 * v257) < 0x20 )
            goto LABEL_50;
          v73 = (__int64)(((unsigned __int64)((-8 * v257) >> 4) >> 59) - 8 * v257) >> 5;
          v74 = 32 * v73;
          v228.m256i_i64[0] = 32 * v73;
          if ( -8 * v257 > 3 )
          {
            if ( v256 - v255 > -32
                             * ((__int64)(((unsigned __int64)((-8 * v257) >> 4) >> 59) - 8 * v257) >> 5)
              || v255 - v256 > -32
                             * ((__int64)(((unsigned __int64)((-8 * v257) >> 4) >> 59) - 8 * v257) >> 5) )
            {
              v74 = 32 * v73;
              ((void (__fastcall *)(char *, char *))sub_140022C10)(v255, v256);
 
              v72 = v74 + 8 * v69;
              _RSI -= v228.m256i_i64[0];
              _RDI -= v228.m256i_i64[0];
 
              __asm { vzeroupper }
              memcpy(_RDI, _RSI, v72);
              v75 = 16 * v233;
              _RDI = v231;
              _RSI = v232;
              if ( (unsigned __int64)(16 * v233) < 0x20 )
                goto LABEL_55;
              v78 = (__int64)(((unsigned __int64)((-16 * v233) >> 4) >> 59) - 16 * v233) >> 5;
              v79 = 32 * v78;
              v80 = 32 * v78;
              v134 = 0i64;
              v135 = 1i64;
              _RAX = 0i64;
              if ( v75 >> 6 )
              {
                do
                {
                  __asm { vmovdqu ymm0, ymmword ptr [rax+rsi] }
                  ++v134;
                  __asm
                  {
                    vmovdqu ymmword ptr [rax+rdi], ymm0
                    vmovdqu ymm1, ymmword ptr [rax+rsi+20h]
                    vmovdqu ymmword ptr [rax+rdi+20h], ymm1
                  }
                  _RAX += 64i64;
                }
                while ( v134 < v75 >> 6 );
                v135 = 2 * v134 + 1;
              }
              v139 = v135 - 1;
              if ( v139 < v75 >> 5 )
              {
                _R10 = 32 * v139;
                __asm
                {
                  vmovdqu ymm0, ymmword ptr [rsi+r10]
                  vmovdqu ymmword ptr [rdi+r10], ymm0
                }
              }
              goto LABEL_54;
            }
            v74 = 32 * v73;
          }
          v142 = 0i64;
          v143 = 1i64;
          _RAX = 0i64;
          if ( v72 >> 6 )
          {
            do
            {
              __asm { vmovdqu ymm0, ymmword ptr [rax+rsi] }
              ++v142;
              __asm
              {
                vmovdqu ymmword ptr [rax+rdi], ymm0
                vmovdqu ymm1, ymmword ptr [rax+rsi+20h]
                vmovdqu ymmword ptr [rax+rdi+20h], ymm1
              }
              _RAX += 64i64;
            }
            while ( v142 < v72 >> 6 );
            v143 = 2 * v142 + 1;
          }
          v147 = v143 - 1;
          if ( v147 < v72 >> 5 )
          {
            _R10 = 32 * v147;
            __asm
            {
              vmovdqu ymm0, ymmword ptr [rsi+r10]
              vmovdqu ymmword ptr [rdi+r10], ymm0
            }
          }
          goto LABEL_49;
        }
        v68 = 32 * v67;
      }
      v150 = 0i64;
      v151 = 1i64;
      _RAX = 0i64;
      if ( v66 >> 6 )
      {
        do
        {
          __asm { vmovdqu ymm0, ymmword ptr [rax+rsi] }
          ++v150;
          __asm
          {
            vmovdqu ymmword ptr [rax+rdi], ymm0
            vmovdqu ymm1, ymmword ptr [rax+rsi+20h]
            vmovdqu ymmword ptr [rax+rdi+20h], ymm1
          }
          _RAX += 64i64;
        }
        while ( v150 < v66 >> 6 );
        v151 = 2 * v150 + 1;
      }
      v155 = v151 - 1;
      if ( v155 < v66 >> 5 )
      {
        _R10 = 32 * v155;
        __asm
        {
          vmovdqu ymm0, ymmword ptr [rsi+r10]
          vmovdqu ymmword ptr [rdi+r10], ymm0
        }
      }
      goto LABEL_44;
    }
    v59 = (__int64)(((unsigned __int64)(-(__int64)v56 >> 4) >> 59) - v56) >> 5;
    v60 = 32 * v59;
    v61 = 32 * v59;
    if ( -(__int64)v56 > 3 )
    {
      if ( _RSI - _RDI > -32
                       * ((__int64)(((unsigned __int64)(-(__int64)v56 >> 4) >> 59) - v56) >> 5)
        || _RDI - _RSI > -32
                       * ((__int64)(((unsigned __int64)(-(__int64)v56 >> 4) >> 59) - v56) >> 5) )
      {
        v61 = 32 * v59;
        ((void (__fastcall *)(char *, char *))sub_140022C10)(_RDI, _RSI);
 
        _RSI -= v60;
        v56 += v61;
        _RDI -= v60;
        goto LABEL_40;
      }
      v61 = 32 * v59;
    }
    v158 = 0i64;
    v159 = 1i64;
    _RAX = 0i64;
    if ( v56 >> 6 )
    {
      do
      {
        __asm { vmovdqu ymm0, ymmword ptr [rax+rsi] }
        ++v158;
        __asm
        {
          vmovdqu ymmword ptr [rax+rdi], ymm0
          vmovdqu ymm1, ymmword ptr [rax+rsi+20h]
          vmovdqu ymmword ptr [rax+rdi+20h], ymm1
        }
        _RAX += 64i64;
      }
      while ( v158 < v56 >> 6 );
      v159 = 2 * v158 + 1;
    }
    v163 = v159 - 1;
    if ( v163 < v56 >> 5 )
    {
      _R10 = 32 * v163;
      __asm
      {
        vmovdqu ymm0, ymmword ptr [rsi+r10]
        vmovdqu ymmword ptr [rdi+r10], ymm0
      }
    }
    goto LABEL_39;
  }
  v46 = 32 * v45;
  return 0i64;
}
}
