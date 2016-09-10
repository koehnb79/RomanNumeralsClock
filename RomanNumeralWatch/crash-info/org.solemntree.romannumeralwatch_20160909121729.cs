S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3409
Date: 2016-09-09 12:17:29-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbed0be64, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbed0b930, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb42be4d0
r10  = 0x0000000c, fp   = 0xbed0b924
ip   = 0x0000000c, sp   = 0xbed0b3b0
lr   = 0xb6bf0f5c, pc   = 0xb6c2b6dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:     12016 KB
Buffers:     10648 KB
Cached:     100616 KB
VmPeak:      63112 KB
VmSize:      62568 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13420 KB
VmRSS:       13420 KB
VmData:      12620 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       45884 KB
VmPTE:          48 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3409 TID = 3409
3409 3411 

Maps Information
b35a4000 b3630000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b3630000 b363f000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b363f000 b3656000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b365e000 b3663000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3663000 b3802000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b3802000 b3889000 rwxs anon_inode:dmabuf
b3889000 b3894000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b389c000 b389d000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b389d000 b389f000 r-xp /usr/lib/libgenlock.so
b38a6000 b38a7000 rwxp /usr/lib/libgenlock.so
b38a7000 b38ab000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b38ab000 b38b2000 r-xs /usr/lib/gconv/gconv-modules.cache
b38b2000 b38b5000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b38bc000 b38bd000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b38be000 b40bd000 rwxp [stack:3411]
b40bd000 b42bd000 r-xp /usr/share/locale/locale-archive
b42c2000 b42c5000 r-xp /lib/libattr.so.1.1.0
b42cc000 b42cd000 rwxp /lib/libattr.so.1.1.0
b42cd000 b42cf000 r-xp /usr/lib/libXau.so.6.0.0
b42d6000 b42d7000 rwxp /usr/lib/libXau.so.6.0.0
b42d8000 b42da000 r-xp /usr/lib/libiniparser.so.0
b42e2000 b42e3000 rwxp /usr/lib/libiniparser.so.0
b42e3000 b42ea000 r-xp /lib/libcrypt-2.13.so
b42f1000 b42f2000 r-xp /lib/libcrypt-2.13.so
b42f2000 b42f3000 rwxp /lib/libcrypt-2.13.so
b431a000 b431d000 r-xp /lib/libcap.so.2.21
b4324000 b4325000 rwxp /lib/libcap.so.2.21
b4325000 b4327000 r-xp /usr/lib/libiri.so
b432e000 b432f000 rwxp /usr/lib/libiri.so
b432f000 b433a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4341000 b4342000 rwxp /usr/lib/libgpg-error.so.0.15.0
b4343000 b44eb000 r-xp /usr/lib/libcrypto.so.1.0.0
b44eb000 b4500000 rwxp /usr/lib/libcrypto.so.1.0.0
b4504000 b4551000 r-xp /usr/lib/libssl.so.1.0.0
b4558000 b455d000 rwxp /usr/lib/libssl.so.1.0.0
b455d000 b458b000 r-xp /usr/lib/libidn.so.11.5.44
b4592000 b4593000 rwxp /usr/lib/libidn.so.11.5.44
b4593000 b459c000 r-xp /usr/lib/libcares.so.2.1.0
b45a4000 b45a5000 rwxp /usr/lib/libcares.so.2.1.0
b45a6000 b45b9000 r-xp /usr/lib/libxcb.so.1.1.0
b45c1000 b45c2000 rwxp /usr/lib/libxcb.so.1.1.0
b45c2000 b45c9000 r-xp /usr/lib/libtbm.so.1.0.0
b45d0000 b45d1000 rwxp /usr/lib/libtbm.so.1.0.0
b45d1000 b45d3000 r-xp /usr/lib/libdri2.so.0.0.0
b45da000 b45db000 rwxp /usr/lib/libdri2.so.0.0.0
b45db000 b45e0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b45e7000 b45e8000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b45e8000 b45f0000 r-xp /usr/lib/libdrm.so.2.4.0
b45f7000 b45f8000 rwxp /usr/lib/libdrm.so.2.4.0
b45f9000 b45fb000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b4602000 b4603000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b4603000 b4605000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b460d000 b460e000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b460e000 b46da000 r-xp /usr/lib/libxml2.so.2.7.8
b46e1000 b46e6000 rwxp /usr/lib/libxml2.so.2.7.8
b46e7000 b4704000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b470c000 b470d000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b470d000 b4710000 r-xp /usr/lib/libsmack.so.1.0.0
b4717000 b4718000 rwxp /usr/lib/libsmack.so.1.0.0
b4719000 b471b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4722000 b4723000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b4723000 b4733000 r-xp /lib/libresolv-2.13.so
b4733000 b4734000 r-xp /lib/libresolv-2.13.so
b4734000 b4735000 rwxp /lib/libresolv-2.13.so
b4737000 b47b3000 r-xp /usr/lib/libgcrypt.so.20.0.3
b47ba000 b47bf000 rwxp /usr/lib/libgcrypt.so.20.0.3
b47bf000 b47d7000 r-xp /usr/lib/liblzma.so.5.0.3
b47de000 b47df000 rwxp /usr/lib/liblzma.so.5.0.3
b47df000 b47f7000 r-xp /usr/lib/libpng12.so.0.50.0
b47fe000 b47ff000 rwxp /usr/lib/libpng12.so.0.50.0
b4800000 b4816000 r-xp /lib/libexpat.so.1.5.2
b481e000 b4820000 rwxp /lib/libexpat.so.1.5.2
b4820000 b4864000 r-xp /usr/lib/libcurl.so.4.3.0
b486b000 b486d000 rwxp /usr/lib/libcurl.so.4.3.0
b486d000 b4877000 r-xp /usr/lib/libXext.so.6.4.0
b487f000 b4880000 rwxp /usr/lib/libXext.so.6.4.0
b4880000 b4884000 r-xp /usr/lib/libXtst.so.6.1.0
b488b000 b488c000 rwxp /usr/lib/libXtst.so.6.1.0
b488c000 b4892000 r-xp /usr/lib/libXrender.so.1.3.0
b4899000 b489a000 rwxp /usr/lib/libXrender.so.1.3.0
b489b000 b48a1000 r-xp /usr/lib/libXrandr.so.2.2.0
b48a8000 b48a9000 rwxp /usr/lib/libXrandr.so.2.2.0
b48a9000 b48aa000 r-xp /usr/lib/libXinerama.so.1.0.0
b48b2000 b48b3000 rwxp /usr/lib/libXinerama.so.1.0.0
b48b3000 b48bc000 r-xp /usr/lib/libXi.so.6.1.0
b48c3000 b48c4000 rwxp /usr/lib/libXi.so.6.1.0
b48c4000 b48c7000 r-xp /usr/lib/libXfixes.so.3.1.0
b48ce000 b48cf000 rwxp /usr/lib/libXfixes.so.3.1.0
b48cf000 b48d1000 r-xp /usr/lib/libXgesture.so.7.0.0
b48d8000 b48d9000 rwxp /usr/lib/libXgesture.so.7.0.0
b48d9000 b48db000 r-xp /usr/lib/libXcomposite.so.1.0.0
b48e2000 b48e3000 rwxp /usr/lib/libXcomposite.so.1.0.0
b48e4000 b48e6000 r-xp /usr/lib/libXdamage.so.1.1.0
b48ed000 b48ee000 rwxp /usr/lib/libXdamage.so.1.1.0
b48ee000 b48f5000 r-xp /usr/lib/libXcursor.so.1.0.2
b48fc000 b48fd000 rwxp /usr/lib/libXcursor.so.1.0.2
b48fd000 b48fe000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4905000 b4906000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b4906000 b490c000 r-xp /usr/lib/libecore_imf.so.1.7.99
b4913000 b4914000 rwxp /usr/lib/libecore_imf.so.1.7.99
b4914000 b492b000 r-xp /usr/lib/liblua-5.1.so
b4933000 b4934000 rwxp /usr/lib/liblua-5.1.so
b4935000 b493c000 r-xp /usr/lib/libembryo.so.1.7.99
b4943000 b4944000 rwxp /usr/lib/libembryo.so.1.7.99
b4944000 b4947000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b494e000 b494f000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b494f000 b4953000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b495b000 b495c000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b495c000 b4961000 r-xp /usr/lib/libecore_fb.so.1.7.99
b4968000 b496a000 rwxp /usr/lib/libecore_fb.so.1.7.99
b496a000 b498d000 r-xp /usr/lib/libjpeg.so.8.0.2
b4994000 b4995000 rwxp /usr/lib/libjpeg.so.8.0.2
b49a6000 b49bc000 r-xp /lib/libz.so.1.2.5
b49c3000 b49c4000 rwxp /lib/libz.so.1.2.5
b49c4000 b4aa5000 r-xp /usr/lib/libX11.so.6.3.0
b4aac000 b4ab0000 rwxp /usr/lib/libX11.so.6.3.0
b4ab0000 b4ab9000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4ac1000 b4ac2000 rwxp /usr/lib/libwidget_provider.so.1.0.0
b4ac2000 b4ac8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b4ad0000 b4ad1000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b4ad1000 b4add000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4ae4000 b4ae5000 rwxp /usr/lib/libwidget_service.so.1.0.0
b4ae6000 b4aef000 r-xp /usr/lib/libcom-core.so.0.0.1
b4af7000 b4af8000 rwxp /usr/lib/libcom-core.so.0.0.1
b4af8000 b6077000 r-xp /usr/lib/libicudata.so.51.1
b607e000 b607f000 rwxp /usr/lib/libicudata.so.51.1
b607f000 b6113000 r-xp /usr/lib/libstdc++.so.6.0.16
b611b000 b611e000 r-xp /usr/lib/libstdc++.so.6.0.16
b611e000 b6120000 rwxp /usr/lib/libstdc++.so.6.0.16
b6126000 b619b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b61a2000 b61a5000 rwxp /usr/lib/libsqlite3.so.0.8.6
b61a5000 b61bb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b61c2000 b61c3000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b61c4000 b61c9000 r-xp /usr/lib/libffi.so.5.0.10
b61d0000 b61d1000 rwxp /usr/lib/libffi.so.5.0.10
b61d1000 b61d7000 r-xp /lib/librt-2.13.so
b61de000 b61df000 r-xp /lib/librt-2.13.so
b61df000 b61e0000 rwxp /lib/librt-2.13.so
b61e0000 b61e1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b61e8000 b61e9000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b61e9000 b61ef000 r-xp /usr/lib/libappsvc.so.0.1.0
b61f6000 b61f7000 rwxp /usr/lib/libappsvc.so.0.1.0
b61f7000 b6224000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b622b000 b622c000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b622d000 b6300000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6307000 b630b000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b630b000 b630e000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6315000 b6316000 rwxp /usr/lib/libproc-stat.so.0.2.86
b6316000 b6352000 r-xp /usr/lib/libsystemd.so.0.4.0
b6359000 b635a000 r-xp /usr/lib/libsystemd.so.0.4.0
b635a000 b635b000 rwxp /usr/lib/libsystemd.so.0.4.0
b635b000 b6360000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6367000 b6368000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6368000 b636b000 r-xp /usr/lib/libbundle.so.0.1.22
b6372000 b6373000 rwxp /usr/lib/libbundle.so.0.1.22
b6374000 b63ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
b63d2000 b63d7000 rwxp /usr/lib/libpixman-1.so.0.28.2
b63d7000 b642d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6435000 b6439000 rwxp /usr/lib/libfreetype.so.6.11.3
b6439000 b6461000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6461000 b6462000 rwxp /usr/lib/libfontconfig.so.1.8.0
b6462000 b649f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b64a6000 b64a7000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b64a8000 b64bb000 r-xp /usr/lib/libfribidi.so.0.3.1
b64c2000 b64c3000 rwxp /usr/lib/libfribidi.so.0.3.1
b64c4000 b64de000 r-xp /usr/lib/libecore_con.so.1.7.99
b64e5000 b64e6000 rwxp /usr/lib/libecore_con.so.1.7.99
b64e7000 b64f0000 r-xp /usr/lib/libedbus.so.1.7.99
b64f7000 b64f8000 rwxp /usr/lib/libedbus.so.1.7.99
b64f8000 b6548000 r-xp /usr/lib/libecore_x.so.1.7.99
b6548000 b654a000 rwxp /usr/lib/libecore_x.so.1.7.99
b654a000 b65a7000 r-xp /usr/lib/libedje.so.1.7.99
b65af000 b65b1000 rwxp /usr/lib/libedje.so.1.7.99
b65b1000 b65c2000 r-xp /usr/lib/libecore_input.so.1.7.99
b65c9000 b65ca000 rwxp /usr/lib/libecore_input.so.1.7.99
b65ca000 b65cf000 r-xp /usr/lib/libecore_file.so.1.7.99
b65d6000 b65d7000 rwxp /usr/lib/libecore_file.so.1.7.99
b65d8000 b65fa000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6601000 b6603000 rwxp /usr/lib/libecore_evas.so.1.7.99
b6603000 b661c000 r-xp /usr/lib/libeet.so.1.7.99
b6624000 b6625000 rwxp /usr/lib/libeet.so.1.7.99
b662d000 b6696000 r-xp /lib/libm-2.13.so
b669d000 b669e000 r-xp /lib/libm-2.13.so
b669e000 b669f000 rwxp /lib/libm-2.13.so
b669f000 b66a5000 r-xp /usr/lib/libwidget.so.1.0.0
b66ad000 b66ae000 rwxp /usr/lib/libwidget.so.1.0.0
b66ae000 b66b4000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b66bb000 b66bc000 rwxp /usr/lib/libwidget_provider_app.so.1.0.0
b66bc000 b66e6000 r-xp /usr/lib/libdbus-1.so.3.8.12
b66ee000 b66ef000 rwxp /usr/lib/libdbus-1.so.3.8.12
b66ef000 b67bf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b67bf000 b67c0000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b67c0000 b67c4000 r-xp /usr/lib/libvconf.so.0.2.45
b67cb000 b67cc000 rwxp /usr/lib/libvconf.so.0.2.45
b67cc000 b68b0000 r-xp /usr/lib/libicuuc.so.51.1
b68b7000 b68c1000 rwxp /usr/lib/libicuuc.so.51.1
b68c5000 b6a02000 r-xp /usr/lib/libicui18n.so.51.1
b6a0a000 b6a12000 rwxp /usr/lib/libicui18n.so.51.1
b6a12000 b6a53000 r-xp /usr/lib/libeina.so.1.7.99
b6a5a000 b6a5c000 rwxp /usr/lib/libeina.so.1.7.99
b6a5c000 b6a73000 r-xp /usr/lib/libecore.so.1.7.99
b6a7b000 b6a7c000 rwxp /usr/lib/libecore.so.1.7.99
b6a8a000 b6aac000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ab3000 b6ab4000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6ab4000 b6ab8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6ac0000 b6ac1000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6ac1000 b6ad5000 r-xp /lib/libpthread-2.13.so
b6adc000 b6add000 r-xp /lib/libpthread-2.13.so
b6add000 b6ade000 rwxp /lib/libpthread-2.13.so
b6ae0000 b6b14000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6b1b000 b6b1d000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6b1d000 b6b2a000 r-xp /usr/lib/libalarm.so.0.0.0
b6b31000 b6b33000 rwxp /usr/lib/libalarm.so.0.0.0
b6b33000 b6b4a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b51000 b6b52000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b52000 b6b5e000 r-xp /usr/lib/libaul.so.0.1.0
b6b66000 b6b67000 rwxp /usr/lib/libaul.so.0.1.0
b6b68000 b6b70000 r-xp /lib/libgcc_s-4.6.so.1
b6b70000 b6b71000 rwxp /lib/libgcc_s-4.6.so.1
b6b71000 b6b73000 r-xp /lib/libdl-2.13.so
b6b7a000 b6b7b000 r-xp /lib/libdl-2.13.so
b6b7b000 b6b7c000 rwxp /lib/libdl-2.13.so
b6b7c000 b6b87000 r-xp /lib/libunwind.so.8.0.1
b6b8e000 b6b8f000 rwxp /lib/libunwind.so.8.0.1
b6bb4000 b6ccf000 r-xp /lib/libc-2.13.so
b6cd7000 b6cd9000 r-xp /lib/libc-2.13.so
b6cd9000 b6cda000 rwxp /lib/libc-2.13.so
b6cdd000 b6dab000 r-xp /usr/lib/libevas.so.1.7.99
b6db3000 b6dbd000 rwxp /usr/lib/libevas.so.1.7.99
b6dd0000 b6f0b000 r-xp /usr/lib/libelementary.so.1.7.99
b6f12000 b6f1a000 rwxp /usr/lib/libelementary.so.1.7.99
b6f21000 b6f23000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2a000 b6f2b000 rwxp /usr/lib/libdlog.so.0.0.0
b6f2b000 b6f2d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f35000 b6f36000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f36000 b6f3d000 r-xp /usr/lib/libappcore-watch.so.1.1
b6f45000 b6f46000 rwxp /usr/lib/libappcore-watch.so.1.1
b6f46000 b6f49000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b6f49000 b6f4b000 r-xp /usr/share/locale/en/LC_MESSAGES/elementary.mo
b6f4b000 b6f4d000 r-xp /usr/share/locale/en_US/LC_MESSAGES/elementary.mo
b6f4e000 b6f53000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6f5a000 b6f5b000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6f5b000 b6f5c000 r-xp /usr/share/locale/locale-archive
b6f5c000 b6f60000 r-xp /usr/lib/libsys-assert.so
b6f68000 b6f69000 rwxp /usr/lib/libsys-assert.so
b6f69000 b6f86000 r-xp /lib/ld-2.13.so
b6f8d000 b6f8e000 r-xp /lib/ld-2.13.so
b6f8e000 b6f8f000 rwxp /lib/ld-2.13.so
b6f8f000 b6f91000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b6f98000 b6f99000 rwxp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b827a000 b83c4000 rwxp [heap]
becec000 bed0d000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3409)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6c2b6dc) [/lib/libc.so.6] + 0x776dc
End of Call Stack

Package Information
Package Name: org.solemntree.romannumeralwatch
Package ID : org.solemntree.romannumeralwatch
Version: 1.0.0
Package Type: rpm
App Name: romannumeralwatch
App ID: org.solemntree.romannumeralwatch
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
nch_sub_init() edje_init done.
09-09 12:17:28.639-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:28.639-0500 E/EFL     ( 3409): elementary<3409> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:28.669-0500 E/EFL     ( 3409): elementary<3409> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:28.679-0500 E/EFL     ( 3409): elementary<3409> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:28.679-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:28.699-0500 E/EFL     ( 3409): elementary<3409> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:28.709-0500 E/EFL     ( 3409): elementary<3409> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:28.709-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:28.709-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:28.709-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:28.709-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:28.709-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:28.829-0500 W/WATCH_CORE( 3409): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:17:28.829-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1573.991821] pkgname: org.solemntree.romannumeralwatch, id: file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1573.991821.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://23068718:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:17:28.829-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[1573.991821] pkgname[org.solemntree.romannumeralwatch], id[file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1573.991821.png] content[] cluster[user,created] category[default] widget_fname[pixmap://23068718:4] gbar_fname[]
09-09 12:17:28.859-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:28.869-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3409
09-09 12:17:28.869-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:17:28.889-0500 E/EFL     ( 3368): elementary<3368> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:28.889-0500 E/EFL     ( 3368): elementary<3368> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:28.889-0500 E/EFL     ( 3368): elementary<3368> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:28.889-0500 E/EFL     ( 3368): elementary<3368> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:28.889-0500 E/EFL     ( 3368): elementary<3368> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:28.889-0500 E/EFL     ( 3368): elementary<3368> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:28.889-0500 E/EFL     ( 3368): elementary<3368> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:28.889-0500 I/AUL_PAD ( 3368): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:17:28.919-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
09-09 12:17:28.919-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
09-09 12:17:29.609-0500 W/AUL_AMD (  934): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:17:29.609-0500 W/AUL_AMD (  934): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
09-09 12:17:29.759-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 4
09-09 12:17:29.759-0500 E/AUL_AMD (  934): amd_request.c: __app_process_by_pid(193) > pid(3409) is dead. cmd(4) is canceled
09-09 12:17:29.779-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 23
09-09 12:17:29.779-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
09-09 12:17:29.779-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3369
09-09 12:17:29.779-0500 W/AUL_AMD (  934): amd_request.c: __send_app_termination_signal(511) > send dead signal done
09-09 12:17:29.779-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3369
09-09 12:17:29.829-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6e7c1b5
09-09 12:17:29.839-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_vconf_clocks_set_idle(6474) > ConnectionType[16] is not BT, ignore this callback.
09-09 12:17:29.839-0500 W/W_HOME  ( 1143): clock_service.c: clock_service_event_handler(821) > scroller freeze off
09-09 12:17:29.839-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6e7c96d
09-09 12:17:29.839-0500 W/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 0 1 1 0
09-09 12:17:29.839-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:17:29.839-0500 E/W_HOME  ( 1143): clock_service.c: _clock_provider_change(396) > clock will be changed to com.samsung.watchface
09-09 12:17:29.869-0500 E/W_HOME  ( 1143): dbox.c: widget_create(365) > add-viewer info none: com.samsung.watchface
09-09 12:17:29.869-0500 W/W_HOME  ( 1143): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
09-09 12:17:29.869-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
09-09 12:17:29.869-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
09-09 12:17:29.869-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:17:29.869-0500 E/W_HOME  ( 1143): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
09-09 12:17:29.869-0500 E/W_HOME  ( 1143): clock_service.c: _clock_error_report(295) > error:org.solemntree.romannumeralwatch treat:3
09-09 12:17:29.879-0500 W/W_HOME  ( 1143): clock_service.c: clock_service_event_handler(821) > scroller freeze off
09-09 12:17:29.879-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6e7c92f
09-09 12:17:29.879-0500 W/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
09-09 12:17:29.879-0500 E/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(544) > not ready to create a new clock:com.samsung.watchface
09-09 12:17:29.879-0500 E/W_HOME  ( 1143): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
09-09 12:17:29.879-0500 W/W_HOME  ( 1143): cs_broker.c: _wms_clock_vconf_cb(283) > 
09-09 12:17:29.889-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6ea18b9
09-09 12:17:29.889-0500 W/W_HOME  ( 1143): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,hide
09-09 12:17:29.929-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
09-09 12:17:29.939-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:29.949-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:29.949-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:17:29.949-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:17:29.969-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:17:29.969-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:17:29.969-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
09-09 12:17:29.969-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:17:30.239-0500 I/efl-extension( 3368): efl_extension.c: eext_mod_init(40) > Init
09-09 12:17:30.239-0500 I/UXT     ( 3368): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
09-09 12:17:30.249-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:17:30.289-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:17:30.309-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_has_glance_bar(1890) > [SECURE_LOG] Handler is invalid
09-09 12:17:30.349-0500 W/WATCH_CORE( 3368): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:17:30.349-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppCreated(498) > 
09-09 12:17:30.349-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1907.352417] pkgname: com.samsung.watchface, id: file:///opt/usr/share/live_magazine/com.samsung.watchface_1143_1907.352417.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:17:30.349-0500 W/W_HOME  ( 1143): dbox.c: _widget_created_cb(244) > widget resume:0xae197510
09-09 12:17:30.349-0500 E/WIDGET_VIEWER( 1143): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
09-09 12:17:30.349-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.watchface:watchface::messageport::event], client = 3368
09-09 12:17:30.369-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:30.369-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
09-09 12:17:30.369-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:30.369-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
09-09 12:17:30.369-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
09-09 12:17:30.379-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
09-09 12:17:30.589-0500 I/Adreno-EGL( 3368): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
09-09 12:17:30.589-0500 I/Adreno-EGL( 3368): OpenGL ES Shader Compiler Version: E031.24.00.16
09-09 12:17:30.589-0500 I/Adreno-EGL( 3368): Build Date: 09/02/15 Wed
09-09 12:17:30.589-0500 I/Adreno-EGL( 3368): Local Branch: 
09-09 12:17:30.589-0500 I/Adreno-EGL( 3368): Remote Branch: 
09-09 12:17:30.589-0500 I/Adreno-EGL( 3368): Local Patches: 
09-09 12:17:30.589-0500 I/Adreno-EGL( 3368): Reconstruct Branch: 
09-09 12:17:30.699-0500 I/DALI    ( 3368): slp-logging.cpp: LogMessage(36) > EGL Information
09-09 12:17:30.699-0500 I/DALI    ( 3368):             Vendor:        Qualcomm, Inc
09-09 12:17:30.699-0500 I/DALI    ( 3368):             Version:       1.4
09-09 12:17:30.699-0500 I/DALI    ( 3368):             Client APIs:   OpenGL_ES
09-09 12:17:30.699-0500 I/DALI    ( 3368):             Extensions:    EGL_QUALCOMM_shared_image EGL_KHR_image EGL_KHR_image_base EGL_QCOM_create_image EGL_KHR_lock_surface EGL_KHR_lock_surface2 EGL_KHR_fence_sync EGL_KHR_cl_eventEGL_IMG_context_priority EGL_KHR_gl_texture_2D_image EGL_KHR_gl_texture_cubemap_image EGL_KHR_gl_texture_3D_image EGL_KHR_gl_renderbuffer_image EGL_EXT_create_context_robustness EGL_NV_post_sub_buffer EGL_ANDROID_blob_cache EGL_ANDROID_framebuffer_target EGL_KHR_create_context EGL_KHR_wait_sync EGL_ANDROIDX_no_config_context EGL_KHR_image_pixmap EGL_TIZEN_image_native_buffer EGL_TIZEN_image_native_surface 
09-09 12:17:30.759-0500 I/watchface-viewer( 3368): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
09-09 12:17:30.779-0500 I/watchface-viewer( 3368): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
09-09 12:17:30.779-0500 I/watchface-viewer( 3368): viewer-view.cpp: View(96) > default camera z[720.000000]
09-09 12:17:30.799-0500 E/BASE_UTILS( 3368): utils_i18n_ucalendar.c: i18n_ucalendar_get_timezone_displayname(113) > (calendar == NULL || result == NULL || buf_size_needed == NULL)
09-09 12:17:30.799-0500 I/watchface-viewer( 3368): viewer-util.cpp: ToUTF8(1214) > i18n_ustring_to_UTF8 returns -22(ffffffea)
09-09 12:17:30.799-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: UpdateTimezone(2876) > timezonePath[America/Chicago] mTimezone[]
09-09 12:17:30.799-0500 I/watchface-viewer( 3368): viewer-impl.cpp: SetDummyMode(96) > dummyMode[3]
09-09 12:17:30.799-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: UpdateTimestamp(1372) > now[1473441450] dummy[1473433840]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-parser.cpp: ParseXML(654) > schema version[0.0]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-parser.cpp: ParseXML(674) > wrong target resolution!!
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-parser.cpp: ParsePart(2188) > draw data set!!
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-parser.cpp: ParsePart(2217) > digital-clock data set!!
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/data-util( 3368): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-parser.cpp: ParsePart(2217) > digital-clock data set!!
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-group-manager.cpp: Clear(32) > 
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-impl.cpp: LoadWatchfaceData(207) > wrong shape [0]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-view.cpp: SetWatchfaceSizeType(676) > watchface size 0x0 shape[0] noMasking[0]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-group.cpp: Group(97) > Group[0xb8a91a70][bg]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-group.cpp: GetDataProvider(229) > DataProvider::Get() [0xb8a71fb8]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-part.cpp: Part(84) > Part[0xb8a961c8]
09-09 12:17:30.839-0500 I/watchface-viewer( 3368): viewer-part-resource.cpp: PartResource(67) > PartResource[0xb8a67a58]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-part-resource.cpp: SetUpdateImage(1981) > new mThread[0xb8a8b0f8]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-part-resource.cpp: ThreadCallback(2108) > thread[0xb8a8b0f8]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-group.cpp: Group(97) > Group[0xb8a8a898][day-1]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-group.cpp: Group(97) > Group[0xb8a8a9e0][time]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-group.cpp: GetDataProvider(229) > DataProvider::Get() [0xb8a71fb8]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-part.cpp: Part(84) > Part[0xb8a8ab28]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-part-resource.cpp: PartResource(67) > PartResource[0xb8a90ab0]
09-09 12:17:30.849-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:30.849-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:30.849-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:30.849-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddListener(590) > added listener[0xb8a90e68] for [27]
09-09 12:17:30.849-0500 I/watchface-viewer( 3368): viewer-util.cpp: GetSystemLocale(694) > mLocale[en_US.UTF-8]
09-09 12:17:30.879-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.879-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateAmPmString(1312) > skeleton[h:mm a] locale[en_US.UTF-8] showAmpmFirst[0]
09-09 12:17:30.879-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.879-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.879-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:30.889-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:30.889-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:30.889-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:30.889-0500 I/watchface-viewer( 3368): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:30.889-0500 E/BASE_UTILS( 3368): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:30.889-0500 I/watchface-viewer( 3368): viewer-util.cpp: Create(864) > created locale[en_US] impl[0xb0faa3c0] refcount[1]
09-09 12:17:30.889-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateAmPmString(1325) > hourString[12] hour[12]
09-09 12:17:30.889-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.889-0500 E/BASE_UTILS( 3368): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:30.889-0500 E/BASE_UTILS( 3368): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:30.889-0500 I/watchface-viewer( 3368): viewer-util.cpp: Destroy(884) > reference decreased locale[en_US] impl[0xb0faa3c0] refcount[0]
09-09 12:17:30.889-0500 I/watchface-viewer( 3368): viewer-util.cpp: Destroy(888) > removed I18NStringUtilityImpl[0xb0faa3c0]
09-09 12:17:30.889-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateAmPmString(1372) > mAm[AM] mPm[PM]
09-09 12:17:30.909-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0xb0fb66c0] size(360x231)
09-09 12:17:30.909-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddListener(590) > added listener[0xb88a73d8] for [13]
09-09 12:17:30.909-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddListener(590) > added listener[0xb8a90e78] for [6]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddListener(590) > added listener[0xb8a84f60] for [4]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-group.cpp: Group(97) > Group[0xb8a8e318][ambient-time]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddDataBroker(1626) > added broker [0xb8a8f5e0]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-data-broker.cpp: AmbientDataBroker(1389) > AmbientDataBroker[0xb8a8f5e0]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-part.cpp: Part(84) > Part[0xb8a8e3d0]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-part-resource.cpp: PartResource(67) > PartResource[0xb8a91f60]
09-09 12:17:30.919-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:30.919-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:30.919-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:30.919-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-data-broker.cpp: AddListener(1402) > added listener[0xb8a926e8] for [27]
09-09 12:17:30.919-0500 I/watchface-viewer( 3368): viewer-util.cpp: GetSystemLocale(694) > mLocale[en_US.UTF-8]
09-09 12:17:30.929-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.939-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateAmPmString(1312) > skeleton[h:mm a] locale[en_US.UTF-8] showAmpmFirst[0]
09-09 12:17:30.939-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.939-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.939-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:30.939-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:30.949-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:30.949-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3368): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:30.949-0500 E/BASE_UTILS( 3368): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-util.cpp: Create(864) > created locale[en_US] impl[0xb8a80a10] refcount[1]
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateAmPmString(1325) > hourString[12] hour[12]
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:30.949-0500 E/BASE_UTILS( 3368): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:30.949-0500 E/BASE_UTILS( 3368): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-util.cpp: Destroy(884) > reference decreased locale[en_US] impl[0xb8a80a10] refcount[0]
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-util.cpp: Destroy(888) > removed I18NStringUtilityImpl[0xb8a80a10]
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateAmPmString(1372) > mAm[AM] mPm[PM]
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0xb8a7e918] size(360x231)
09-09 12:17:30.949-0500 I/watchface-viewer( 3368): viewer-data-broker.cpp: AddListener(1402) > added listener[0xb8a81338] for [13]
09-09 12:17:30.959-0500 I/watchface-viewer( 3368): viewer-data-broker.cpp: AddListener(1402) > added listener[0xb8a8ffe8] for [6]
09-09 12:17:30.959-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: ConnectModels(1444) > models will be connected later when first resume received!!
09-09 12:17:30.959-0500 I/watchface-viewer( 3368): viewer-parser.cpp: ~ParserWatchfaceData(519) > 
09-09 12:17:30.959-0500 W/WATCH_CORE( 3368): appcore-watch.c: __widget_create(976) > widget_create done
09-09 12:17:31.059-0500 I/WATCH_CORE( 3368): appcore-watch.c: __watch_core_set_metadata(818) > Tick per second: 5
09-09 12:17:31.059-0500 I/WATCH_CORE( 3368): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
09-09 12:17:31.059-0500 W/WATCH_CORE( 3368): appcore-watch.c: __watch_core_set_metadata(845) > Watchface type
09-09 12:17:31.099-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppControl(676) > 
09-09 12:17:31.099-0500 I/watchface-viewer( 3368): viewer-part-resource.cpp: ThreadNotifyCallback(2170) > thread[0xb8a8b0f8]
09-09 12:17:31.099-0500 I/watchface-viewer( 3368): viewer-part-resource.cpp: ThreadEndCallback(2206) > thread[0xb8a8b0f8]
09-09 12:17:31.099-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:17:31.099-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:17:31.099-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:17:31.099-0500 I/watchface-viewer( 3368): viewer-util.cpp: GetAppId(61) > appId[com.samsung.watchface]
09-09 12:17:31.139-0500 E/EFL     ( 3368): elementary<3368> elm_layout.c:2207 elm_layout_add() could not add 0xb8a8b548 as sub object of 0xb8a8b258
09-09 12:17:31.179-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: CreateImage(136) > resized 360x231 -> 334x231
09-09 12:17:31.179-0500 E/EFL     ( 3368): edje<3368> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:17:31.199-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateLayout(1257) > colon 30x182 at (152,0)
09-09 12:17:31.199-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:17:31.199-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:17:31.199-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:17:31.199-0500 E/EFL     ( 3368): elementary<3368> elm_layout.c:2207 elm_layout_add() could not add 0xb8a8bf90 as sub object of 0xb8a8b3d0
09-09 12:17:31.199-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: CreateImage(136) > resized 360x231 -> 334x231
09-09 12:17:31.209-0500 E/EFL     ( 3368): edje<3368> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:17:31.219-0500 W/WATCH_CORE( 3368): appcore-watch.c: __widget_resume(1012) > widget_resume
09-09 12:17:31.249-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppResume(721) > 
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [27]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [13]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [6]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:17:31.249-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppResume(728) > mFirstResumeDone
09-09 12:17:31.249-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:31.249-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [1] to pending list
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [2] to pending list
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [3]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [3] to pending list
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [4]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [4] to pending list
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [5]
09-09 12:17:31.249-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [5] to pending list
09-09 12:17:31.259-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:17:31.269-0500 I/watchface-viewer( 3368): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
09-09 12:17:31.269-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnLoadingDone(808) > 
09-09 12:17:31.269-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnLoadingDone(811) > idle_watch = [com.samsung.watchface]
09-09 12:17:31.269-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnLoadingDone(819) > idle_watch = [com.samsung.watchface]
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watch-face-editor:watch-face-editor::localport]
09-09 12:17:31.269-0500 E/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:31.269-0500 E/MESSAGE_PORT( 3368): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (watch-face-editor::localport) is not found.
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.clocksetting.clock:clocksetting::localport]
09-09 12:17:31.269-0500 E/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:17:31.269-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:31.279-0500 E/MESSAGE_PORT( 3368): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (clocksetting::localport) is not found.
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:w-home::localport]
09-09 12:17:31.279-0500 E/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:17:31.279-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:31.279-0500 W/AUL_AMD (  934): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:17:31.279-0500 W/AUL_AMD (  934): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
09-09 12:17:31.279-0500 E/MESSAGE_PORT( 3368): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (w-home::localport) is not found.
09-09 12:17:31.279-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnLoadingDone(856) > mFirstLoadingDone
09-09 12:17:31.299-0500 W/W_HOME  ( 1143): clock_view.c: clock_view_attach(552) > changed pause/resume option -> manual
09-09 12:17:31.299-0500 W/W_HOME  ( 1143): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
09-09 12:17:31.299-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:31.329-0500 W/W_HOME  ( 1143): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
09-09 12:17:31.329-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:31.329-0500 W/W_HOME  ( 1143): clock_view.c: clock_view_attach(569) > changed pause/resume option -> automatic
09-09 12:17:31.329-0500 W/W_HOME  ( 1143): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
09-09 12:17:31.329-0500 E/W_HOME  ( 1143): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
09-09 12:17:31.329-0500 E/W_HOME  ( 1143): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
09-09 12:17:31.329-0500 W/W_HOME  ( 1143): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
09-09 12:17:31.339-0500 E/W_HOME  ( 1143): dbox.c: del_cb(231) > Add viewer has no info: org.solemntree.romannumeralwatch
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_service.c: clock_service_event_handler(821) > scroller freeze off
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6e7c92f
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
09-09 12:17:31.339-0500 E/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(563) > com.samsung.watchface is already attached to home
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): cfwd.c: cfwd_get_icon_status(362) > 
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): ============================
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): multi_sim_category:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): multi_sim_model:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): support_callforward_auto:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): conn_status:16
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): remote_call_forward_auto:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): auto_call_forward_status:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): support_callforward_reverse:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): reverse_call_forward_auto:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): fwd_type:ARS
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): ============================
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): 
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(374) > network status : 0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(379) > sap_connected : 1
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(385) > sap connectivity type : 16
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(391) > network status : 2
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(398) > svc type : 7
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(405) > scs login : 1
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(433) > network connection via WIFI : no checking svc_type
09-09 12:17:31.339-0500 E/W_HOME  ( 1143): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): noti_broker.c: _clock_attached_cb(809) > 0
09-09 12:17:31.339-0500 W/W_HOME  ( 1143): cs_broker.c: _clock_view_attached_cb(231) > 
09-09 12:17:31.349-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
09-09 12:17:31.349-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
09-09 12:17:31.389-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:31.399-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3368
09-09 12:17:31.399-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:17:31.439-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:31.439-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:31.439-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:31.439-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:31.489-0500 E/W_HOME  ( 1143): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
09-09 12:17:31.529-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103369726f6d1473441446
09-09 12:17:31.609-0500 E/EFL     ( 3454): elementary<3454> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:31.609-0500 E/EFL     ( 3454): elementary<3454> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:31.619-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnDummyModeOffTimerExpired(392) > disable dummy mode
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-impl.cpp: SetDummyMode(96) > dummyMode[0]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [1]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [2]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [3]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [4]
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: Notify(984) > skip first tick after resume!!
09-09 12:17:31.619-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [5]
09-09 12:17:31.619-0500 E/EFL     ( 3368): elementary<3368> elm_layout.c:2207 elm_layout_add() could not add 0xb8a8c9d8 as sub object of 0xb8a8b258
09-09 12:17:31.619-0500 E/EFL     ( 3368): edje<3368> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:17:31.629-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: UpdateLayout(1257) > colon 30x182 at (152,0)
09-09 12:17:31.629-0500 I/watchface-viewer( 3368): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
09-09 12:17:31.629-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:31.629-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:31.689-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103409726f6d147344144
