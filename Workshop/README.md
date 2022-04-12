=====[ TRAFFICLIGHT ]
- [x] por defecto? -> verde
  - [?] (se podría mirar si apagado)
- [?] apagar o encender?
  - No parece una api poco ambigua.
- [x] rojo, ámbar, verde
- [x] cambiar el color de la luz
- [x] cambiar a siguiente
- [x] modo de emergencia (ámbar parpadeante)
- [ ] no modo de emergencia -> no parpadeo
- [ ] dar soporte a mensaje que pasa de ámbar a verde
- [ ] temporizador de semáforo
- [ ] Trafficlight
- [?] ¿qué pasa si cambia en medio del modo de emergencia?
  - [x] Yo voy a tirar precondición

=====[ ISO 8583 ]
- [ ] Recibe binario por constructor (string).
- [ ] Devuelve hexadecimal (string).
- [ ] 0 -> 0x00;
- [ ] 1 -> 0x01;
- [ ] 16 -> 0x10;
- [ ] ¿si longitud es distinta de 64 o 128?
  - Nosotros permitimos pero ¿se quiere precondición?