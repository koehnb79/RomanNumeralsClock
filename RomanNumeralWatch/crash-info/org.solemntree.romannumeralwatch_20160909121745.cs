S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3626
Date: 2016-09-09 12:17:45-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbee76e64, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbee76930, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb432c4d0
r10  = 0x0000000c, fp   = 0xbee76924
ip   = 0x0000000c, sp   = 0xbee763b0
lr   = 0xb6c5ef5c, pc   = 0xb6c996dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:     19468 KB
Buffers:      8984 KB
Cached:      89532 KB
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
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3626 TID = 3626
3626 3629 

Maps Information
b3612000 b369e000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b369e000 b36ad000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b36ad000 b36c4000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b36cc000 b36d1000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b36d1000 b3870000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b3870000 b38f7000 rwxs anon_inode:dmabuf
b38f7000 b3902000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b390a000 b390b000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b390b000 b390d000 r-xp /usr/lib/libgenlock.so
b3914000 b3915000 rwxp /usr/lib/libgenlock.so
b3915000 b3919000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b3919000 b3920000 r-xs /usr/lib/gconv/gconv-modules.cache
b3920000 b3923000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b392a000 b392b000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b392c000 b412b000 rwxp [stack:3629]
b412b000 b432b000 r-xp /usr/share/locale/locale-archive
b4330000 b4333000 r-xp /lib/libattr.so.1.1.0
b433a000 b433b000 rwxp /lib/libattr.so.1.1.0
b433b000 b433d000 r-xp /usr/lib/libXau.so.6.0.0
b4344000 b4345000 rwxp /usr/lib/libXau.so.6.0.0
b4346000 b4348000 r-xp /usr/lib/libiniparser.so.0
b4350000 b4351000 rwxp /usr/lib/libiniparser.so.0
b4351000 b4358000 r-xp /lib/libcrypt-2.13.so
b435f000 b4360000 r-xp /lib/libcrypt-2.13.so
b4360000 b4361000 rwxp /lib/libcrypt-2.13.so
b4388000 b438b000 r-xp /lib/libcap.so.2.21
b4392000 b4393000 rwxp /lib/libcap.so.2.21
b4393000 b4395000 r-xp /usr/lib/libiri.so
b439c000 b439d000 rwxp /usr/lib/libiri.so
b439d000 b43a8000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43af000 b43b0000 rwxp /usr/lib/libgpg-error.so.0.15.0
b43b1000 b4559000 r-xp /usr/lib/libcrypto.so.1.0.0
b4559000 b456e000 rwxp /usr/lib/libcrypto.so.1.0.0
b4572000 b45bf000 r-xp /usr/lib/libssl.so.1.0.0
b45c6000 b45cb000 rwxp /usr/lib/libssl.so.1.0.0
b45cb000 b45f9000 r-xp /usr/lib/libidn.so.11.5.44
b4600000 b4601000 rwxp /usr/lib/libidn.so.11.5.44
b4601000 b460a000 r-xp /usr/lib/libcares.so.2.1.0
b4612000 b4613000 rwxp /usr/lib/libcares.so.2.1.0
b4614000 b4627000 r-xp /usr/lib/libxcb.so.1.1.0
b462f000 b4630000 rwxp /usr/lib/libxcb.so.1.1.0
b4630000 b4637000 r-xp /usr/lib/libtbm.so.1.0.0
b463e000 b463f000 rwxp /usr/lib/libtbm.so.1.0.0
b463f000 b4641000 r-xp /usr/lib/libdri2.so.0.0.0
b4648000 b4649000 rwxp /usr/lib/libdri2.so.0.0.0
b4649000 b464e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4655000 b4656000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b4656000 b465e000 r-xp /usr/lib/libdrm.so.2.4.0
b4665000 b4666000 rwxp /usr/lib/libdrm.so.2.4.0
b4667000 b4669000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b4670000 b4671000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b4671000 b4673000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b467b000 b467c000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b467c000 b4748000 r-xp /usr/lib/libxml2.so.2.7.8
b474f000 b4754000 rwxp /usr/lib/libxml2.so.2.7.8
b4755000 b4772000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b477a000 b477b000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b477b000 b477e000 r-xp /usr/lib/libsmack.so.1.0.0
b4785000 b4786000 rwxp /usr/lib/libsmack.so.1.0.0
b4787000 b4789000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4790000 b4791000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b4791000 b47a1000 r-xp /lib/libresolv-2.13.so
b47a1000 b47a2000 r-xp /lib/libresolv-2.13.so
b47a2000 b47a3000 rwxp /lib/libresolv-2.13.so
b47a5000 b4821000 r-xp /usr/lib/libgcrypt.so.20.0.3
b4828000 b482d000 rwxp /usr/lib/libgcrypt.so.20.0.3
b482d000 b4845000 r-xp /usr/lib/liblzma.so.5.0.3
b484c000 b484d000 rwxp /usr/lib/liblzma.so.5.0.3
b484d000 b4865000 r-xp /usr/lib/libpng12.so.0.50.0
b486c000 b486d000 rwxp /usr/lib/libpng12.so.0.50.0
b486e000 b4884000 r-xp /lib/libexpat.so.1.5.2
b488c000 b488e000 rwxp /lib/libexpat.so.1.5.2
b488e000 b48d2000 r-xp /usr/lib/libcurl.so.4.3.0
b48d9000 b48db000 rwxp /usr/lib/libcurl.so.4.3.0
b48db000 b48e5000 r-xp /usr/lib/libXext.so.6.4.0
b48ed000 b48ee000 rwxp /usr/lib/libXext.so.6.4.0
b48ee000 b48f2000 r-xp /usr/lib/libXtst.so.6.1.0
b48f9000 b48fa000 rwxp /usr/lib/libXtst.so.6.1.0
b48fa000 b4900000 r-xp /usr/lib/libXrender.so.1.3.0
b4907000 b4908000 rwxp /usr/lib/libXrender.so.1.3.0
b4909000 b490f000 r-xp /usr/lib/libXrandr.so.2.2.0
b4916000 b4917000 rwxp /usr/lib/libXrandr.so.2.2.0
b4917000 b4918000 r-xp /usr/lib/libXinerama.so.1.0.0
b4920000 b4921000 rwxp /usr/lib/libXinerama.so.1.0.0
b4921000 b492a000 r-xp /usr/lib/libXi.so.6.1.0
b4931000 b4932000 rwxp /usr/lib/libXi.so.6.1.0
b4932000 b4935000 r-xp /usr/lib/libXfixes.so.3.1.0
b493c000 b493d000 rwxp /usr/lib/libXfixes.so.3.1.0
b493d000 b493f000 r-xp /usr/lib/libXgesture.so.7.0.0
b4946000 b4947000 rwxp /usr/lib/libXgesture.so.7.0.0
b4947000 b4949000 r-xp /usr/lib/libXcomposite.so.1.0.0
b4950000 b4951000 rwxp /usr/lib/libXcomposite.so.1.0.0
b4952000 b4954000 r-xp /usr/lib/libXdamage.so.1.1.0
b495b000 b495c000 rwxp /usr/lib/libXdamage.so.1.1.0
b495c000 b4963000 r-xp /usr/lib/libXcursor.so.1.0.2
b496a000 b496b000 rwxp /usr/lib/libXcursor.so.1.0.2
b496b000 b496c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4973000 b4974000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b4974000 b497a000 r-xp /usr/lib/libecore_imf.so.1.7.99
b4981000 b4982000 rwxp /usr/lib/libecore_imf.so.1.7.99
b4982000 b4999000 r-xp /usr/lib/liblua-5.1.so
b49a1000 b49a2000 rwxp /usr/lib/liblua-5.1.so
b49a3000 b49aa000 r-xp /usr/lib/libembryo.so.1.7.99
b49b1000 b49b2000 rwxp /usr/lib/libembryo.so.1.7.99
b49b2000 b49b5000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b49bc000 b49bd000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b49bd000 b49c1000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b49c9000 b49ca000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b49ca000 b49cf000 r-xp /usr/lib/libecore_fb.so.1.7.99
b49d6000 b49d8000 rwxp /usr/lib/libecore_fb.so.1.7.99
b49d8000 b49fb000 r-xp /usr/lib/libjpeg.so.8.0.2
b4a02000 b4a03000 rwxp /usr/lib/libjpeg.so.8.0.2
b4a14000 b4a2a000 r-xp /lib/libz.so.1.2.5
b4a31000 b4a32000 rwxp /lib/libz.so.1.2.5
b4a32000 b4b13000 r-xp /usr/lib/libX11.so.6.3.0
b4b1a000 b4b1e000 rwxp /usr/lib/libX11.so.6.3.0
b4b1e000 b4b27000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4b2f000 b4b30000 rwxp /usr/lib/libwidget_provider.so.1.0.0
b4b30000 b4b36000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b4b3e000 b4b3f000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b4b3f000 b4b4b000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4b52000 b4b53000 rwxp /usr/lib/libwidget_service.so.1.0.0
b4b54000 b4b5d000 r-xp /usr/lib/libcom-core.so.0.0.1
b4b65000 b4b66000 rwxp /usr/lib/libcom-core.so.0.0.1
b4b66000 b60e5000 r-xp /usr/lib/libicudata.so.51.1
b60ec000 b60ed000 rwxp /usr/lib/libicudata.so.51.1
b60ed000 b6181000 r-xp /usr/lib/libstdc++.so.6.0.16
b6189000 b618c000 r-xp /usr/lib/libstdc++.so.6.0.16
b618c000 b618e000 rwxp /usr/lib/libstdc++.so.6.0.16
b6194000 b6209000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6210000 b6213000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6213000 b6229000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6230000 b6231000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6232000 b6237000 r-xp /usr/lib/libffi.so.5.0.10
b623e000 b623f000 rwxp /usr/lib/libffi.so.5.0.10
b623f000 b6245000 r-xp /lib/librt-2.13.so
b624c000 b624d000 r-xp /lib/librt-2.13.so
b624d000 b624e000 rwxp /lib/librt-2.13.so
b624e000 b624f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6256000 b6257000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6257000 b625d000 r-xp /usr/lib/libappsvc.so.0.1.0
b6264000 b6265000 rwxp /usr/lib/libappsvc.so.0.1.0
b6265000 b6292000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6299000 b629a000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b629b000 b636e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6375000 b6379000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6379000 b637c000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6383000 b6384000 rwxp /usr/lib/libproc-stat.so.0.2.86
b6384000 b63c0000 r-xp /usr/lib/libsystemd.so.0.4.0
b63c7000 b63c8000 r-xp /usr/lib/libsystemd.so.0.4.0
b63c8000 b63c9000 rwxp /usr/lib/libsystemd.so.0.4.0
b63c9000 b63ce000 r-xp /usr/lib/libxdgmime.so.1.1.0
b63d5000 b63d6000 rwxp /usr/lib/libxdgmime.so.1.1.0
b63d6000 b63d9000 r-xp /usr/lib/libbundle.so.0.1.22
b63e0000 b63e1000 rwxp /usr/lib/libbundle.so.0.1.22
b63e2000 b6438000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6440000 b6445000 rwxp /usr/lib/libpixman-1.so.0.28.2
b6445000 b649b000 r-xp /usr/lib/libfreetype.so.6.11.3
b64a3000 b64a7000 rwxp /usr/lib/libfreetype.so.6.11.3
b64a7000 b64cf000 r-xp /usr/lib/libfontconfig.so.1.8.0
b64cf000 b64d0000 rwxp /usr/lib/libfontconfig.so.1.8.0
b64d0000 b650d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6514000 b6515000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b6516000 b6529000 r-xp /usr/lib/libfribidi.so.0.3.1
b6530000 b6531000 rwxp /usr/lib/libfribidi.so.0.3.1
b6532000 b654c000 r-xp /usr/lib/libecore_con.so.1.7.99
b6553000 b6554000 rwxp /usr/lib/libecore_con.so.1.7.99
b6555000 b655e000 r-xp /usr/lib/libedbus.so.1.7.99
b6565000 b6566000 rwxp /usr/lib/libedbus.so.1.7.99
b6566000 b65b6000 r-xp /usr/lib/libecore_x.so.1.7.99
b65b6000 b65b8000 rwxp /usr/lib/libecore_x.so.1.7.99
b65b8000 b6615000 r-xp /usr/lib/libedje.so.1.7.99
b661d000 b661f000 rwxp /usr/lib/libedje.so.1.7.99
b661f000 b6630000 r-xp /usr/lib/libecore_input.so.1.7.99
b6637000 b6638000 rwxp /usr/lib/libecore_input.so.1.7.99
b6638000 b663d000 r-xp /usr/lib/libecore_file.so.1.7.99
b6644000 b6645000 rwxp /usr/lib/libecore_file.so.1.7.99
b6646000 b6668000 r-xp /usr/lib/libecore_evas.so.1.7.99
b666f000 b6671000 rwxp /usr/lib/libecore_evas.so.1.7.99
b6671000 b668a000 r-xp /usr/lib/libeet.so.1.7.99
b6692000 b6693000 rwxp /usr/lib/libeet.so.1.7.99
b669b000 b6704000 r-xp /lib/libm-2.13.so
b670b000 b670c000 r-xp /lib/libm-2.13.so
b670c000 b670d000 rwxp /lib/libm-2.13.so
b670d000 b6713000 r-xp /usr/lib/libwidget.so.1.0.0
b671b000 b671c000 rwxp /usr/lib/libwidget.so.1.0.0
b671c000 b6722000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b6729000 b672a000 rwxp /usr/lib/libwidget_provider_app.so.1.0.0
b672a000 b6754000 r-xp /usr/lib/libdbus-1.so.3.8.12
b675c000 b675d000 rwxp /usr/lib/libdbus-1.so.3.8.12
b675d000 b682d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b682d000 b682e000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b682e000 b6832000 r-xp /usr/lib/libvconf.so.0.2.45
b6839000 b683a000 rwxp /usr/lib/libvconf.so.0.2.45
b683a000 b691e000 r-xp /usr/lib/libicuuc.so.51.1
b6925000 b692f000 rwxp /usr/lib/libicuuc.so.51.1
b6933000 b6a70000 r-xp /usr/lib/libicui18n.so.51.1
b6a78000 b6a80000 rwxp /usr/lib/libicui18n.so.51.1
b6a80000 b6ac1000 r-xp /usr/lib/libeina.so.1.7.99
b6ac8000 b6aca000 rwxp /usr/lib/libeina.so.1.7.99
b6aca000 b6ae1000 r-xp /usr/lib/libecore.so.1.7.99
b6ae9000 b6aea000 rwxp /usr/lib/libecore.so.1.7.99
b6af8000 b6b1a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b21000 b6b22000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6b22000 b6b26000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6b2e000 b6b2f000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6b2f000 b6b43000 r-xp /lib/libpthread-2.13.so
b6b4a000 b6b4b000 r-xp /lib/libpthread-2.13.so
b6b4b000 b6b4c000 rwxp /lib/libpthread-2.13.so
b6b4e000 b6b82000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6b89000 b6b8b000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6b8b000 b6b98000 r-xp /usr/lib/libalarm.so.0.0.0
b6b9f000 b6ba1000 rwxp /usr/lib/libalarm.so.0.0.0
b6ba1000 b6bb8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bbf000 b6bc0000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc0000 b6bcc000 r-xp /usr/lib/libaul.so.0.1.0
b6bd4000 b6bd5000 rwxp /usr/lib/libaul.so.0.1.0
b6bd6000 b6bde000 r-xp /lib/libgcc_s-4.6.so.1
b6bde000 b6bdf000 rwxp /lib/libgcc_s-4.6.so.1
b6bdf000 b6be1000 r-xp /lib/libdl-2.13.so
b6be8000 b6be9000 r-xp /lib/libdl-2.13.so
b6be9000 b6bea000 rwxp /lib/libdl-2.13.so
b6bea000 b6bf5000 r-xp /lib/libunwind.so.8.0.1
b6bfc000 b6bfd000 rwxp /lib/libunwind.so.8.0.1
b6c22000 b6d3d000 r-xp /lib/libc-2.13.so
b6d45000 b6d47000 r-xp /lib/libc-2.13.so
b6d47000 b6d48000 rwxp /lib/libc-2.13.so
b6d4b000 b6e19000 r-xp /usr/lib/libevas.so.1.7.99
b6e21000 b6e2b000 rwxp /usr/lib/libevas.so.1.7.99
b6e3e000 b6f79000 r-xp /usr/lib/libelementary.so.1.7.99
b6f80000 b6f88000 rwxp /usr/lib/libelementary.so.1.7.99
b6f8f000 b6f91000 r-xp /usr/lib/libdlog.so.0.0.0
b6f98000 b6f99000 rwxp /usr/lib/libdlog.so.0.0.0
b6f99000 b6f9b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6fa3000 b6fa4000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6fa4000 b6fab000 r-xp /usr/lib/libappcore-watch.so.1.1
b6fb3000 b6fb4000 rwxp /usr/lib/libappcore-watch.so.1.1
b6fb4000 b6fb7000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b6fb7000 b6fb9000 r-xp /usr/share/locale/en/LC_MESSAGES/elementary.mo
b6fb9000 b6fbb000 r-xp /usr/share/locale/en_US/LC_MESSAGES/elementary.mo
b6fbc000 b6fc1000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6fc8000 b6fc9000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6fc9000 b6fca000 r-xp /usr/share/locale/locale-archive
b6fca000 b6fce000 r-xp /usr/lib/libsys-assert.so
b6fd6000 b6fd7000 rwxp /usr/lib/libsys-assert.so
b6fd7000 b6ff4000 r-xp /lib/ld-2.13.so
b6ffb000 b6ffc000 r-xp /lib/ld-2.13.so
b6ffc000 b6ffd000 rwxp /lib/ld-2.13.so
b6ffd000 b6fff000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b7006000 b7007000 rwxp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b8a18000 b8b62000 rwxp [heap]
bee57000 bee78000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3626)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6c996dc) [/lib/libc.so.6] + 0x776dc
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
widget.c: widget_viewer_has_glance_bar(1890) > [SECURE_LOG] Handler is invalid
09-09 12:17:48.049-0500 I/efl-extension( 3653): efl_extension.c: eext_mod_init(40) > Init
09-09 12:17:48.059-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:48.059-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:48.079-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:48.079-0500 I/UXT     ( 3653): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
09-09 12:17:48.079-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:48.109-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:48.109-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:48.119-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:48.119-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:48.119-0500 E/EFL     ( 3653): elementary<3653> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:48.139-0500 E/EFL     ( 3653): elementary<3653> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:48.139-0500 E/EFL     ( 3653): elementary<3653> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:48.139-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:48.169-0500 E/EFL     ( 3653): elementary<3653> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:48.169-0500 E/EFL     ( 3653): elementary<3653> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:48.169-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:48.169-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:48.169-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:48.169-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:48.169-0500 E/EFL     ( 3653): elementary<3653> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:48.169-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:17:48.269-0500 W/WATCH_CORE( 3653): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:17:48.269-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppCreated(498) > 
09-09 12:17:48.269-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
09-09 12:17:48.269-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1925.007935] pkgname: com.samsung.watchface, id: file:///opt/usr/share/live_magazine/com.samsung.watchface_1143_1925.007935.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:17:48.269-0500 W/W_HOME  ( 1143): dbox.c: _widget_created_cb(244) > widget resume:0xad5d7278
09-09 12:17:48.269-0500 E/WIDGET_VIEWER( 1143): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
09-09 12:17:48.289-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
09-09 12:17:48.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.watchface:watchface::messageport::event], client = 3653
09-09 12:17:48.299-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
09-09 12:17:48.299-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
09-09 12:17:48.419-0500 I/Adreno-EGL( 3653): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
09-09 12:17:48.419-0500 I/Adreno-EGL( 3653): OpenGL ES Shader Compiler Version: E031.24.00.16
09-09 12:17:48.419-0500 I/Adreno-EGL( 3653): Build Date: 09/02/15 Wed
09-09 12:17:48.419-0500 I/Adreno-EGL( 3653): Local Branch: 
09-09 12:17:48.419-0500 I/Adreno-EGL( 3653): Remote Branch: 
09-09 12:17:48.419-0500 I/Adreno-EGL( 3653): Local Patches: 
09-09 12:17:48.419-0500 I/Adreno-EGL( 3653): Reconstruct Branch: 
09-09 12:17:48.429-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:48.439-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:48.449-0500 I/watchface-viewer( 3653): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
09-09 12:17:48.449-0500 I/watchface-viewer( 3653): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
09-09 12:17:48.459-0500 I/watchface-viewer( 3653): viewer-view.cpp: View(96) > default camera z[720.000000]
09-09 12:17:48.459-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:48.459-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:48.499-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:48.499-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:48.499-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:48.499-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:48.499-0500 E/EFL     ( 3652): elementary<3652> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:48.519-0500 I/DALI    ( 3653): slp-logging.cpp: LogMessage(36) > EGL Information
09-09 12:17:48.519-0500 I/DALI    ( 3653):             Vendor:        Qualcomm, Inc
09-09 12:17:48.519-0500 I/DALI    ( 3653):             Version:       1.4
09-09 12:17:48.519-0500 I/DALI    ( 3653):             Client APIs:   OpenGL_ES
09-09 12:17:48.519-0500 I/DALI    ( 3653):             Extensions:    EGL_QUALCOMM_shared_image EGL_KHR_image EGL_KHR_image_base EGL_QCOM_create_image EGL_KHR_lock_surface EGL_KHR_lock_surface2 EGL_KHR_fence_sync EGL_KHR_cl_eventEGL_IMG_context_priority EGL_KHR_gl_texture_2D_image EGL_KHR_gl_texture_cubemap_image EGL_KHR_gl_texture_3D_image EGL_KHR_gl_renderbuffer_image EGL_EXT_create_context_robustness EGL_NV_post_sub_buffer EGL_ANDROID_blob_cache EGL_ANDROID_framebuffer_target EGL_KHR_create_context EGL_KHR_wait_sync EGL_ANDROIDX_no_config_context EGL_KHR_image_pixmap EGL_TIZEN_image_native_buffer EGL_TIZEN_image_native_surface 
09-09 12:17:48.529-0500 E/EFL     ( 3652): elementary<3652> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:48.529-0500 E/EFL     ( 3652): elementary<3652> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:48.529-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:48.549-0500 E/BASE_UTILS( 3653): utils_i18n_ucalendar.c: i18n_ucalendar_get_timezone_displayname(113) > (calendar == NULL || result == NULL || buf_size_needed == NULL)
09-09 12:17:48.549-0500 I/watchface-viewer( 3653): viewer-util.cpp: ToUTF8(1214) > i18n_ustring_to_UTF8 returns -22(ffffffea)
09-09 12:17:48.549-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: UpdateTimezone(2876) > timezonePath[America/Chicago] mTimezone[]
09-09 12:17:48.549-0500 I/watchface-viewer( 3653): viewer-impl.cpp: SetDummyMode(96) > dummyMode[3]
09-09 12:17:48.549-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: UpdateTimestamp(1372) > now[1473441468] dummy[1473433840]
09-09 12:17:48.559-0500 I/watchface-viewer( 3653): viewer-parser.cpp: ParseXML(654) > schema version[0.0]
09-09 12:17:48.559-0500 I/watchface-viewer( 3653): viewer-parser.cpp: ParseXML(674) > wrong target resolution!!
09-09 12:17:48.559-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.559-0500 I/watchface-viewer( 3653): viewer-parser.cpp: ParsePart(2188) > draw data set!!
09-09 12:17:48.559-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.559-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.559-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.559-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.569-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.569-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-parser.cpp: ParsePart(2217) > digital-clock data set!!
09-09 12:17:48.569-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.569-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.569-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.569-0500 I/data-util( 3653): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-parser.cpp: ParsePart(2217) > digital-clock data set!!
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-group-manager.cpp: Clear(32) > 
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-impl.cpp: LoadWatchfaceData(207) > wrong shape [0]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-view.cpp: SetWatchfaceSizeType(676) > watchface size 0x0 shape[0] noMasking[0]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-group.cpp: Group(97) > Group[0xb80279c0][bg]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-group.cpp: GetDataProvider(229) > DataProvider::Get() [0xb8010d48]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-part.cpp: Part(84) > Part[0xb8011668]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-part-resource.cpp: PartResource(67) > PartResource[0xb803cf10]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-part-resource.cpp: SetUpdateImage(1981) > new mThread[0xb8032520]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-group.cpp: Group(97) > Group[0xb80266c8][day-1]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-group.cpp: Group(97) > Group[0xb8022d28][time]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-group.cpp: GetDataProvider(229) > DataProvider::Get() [0xb8010d48]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-part.cpp: Part(84) > Part[0xb8022e70]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-part-resource.cpp: PartResource(67) > PartResource[0xb8022828]
09-09 12:17:48.569-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:48.569-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:48.569-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:48.569-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddListener(590) > added listener[0xb80323f8] for [27]
09-09 12:17:48.569-0500 I/watchface-viewer( 3653): viewer-util.cpp: GetSystemLocale(694) > mLocale[en_US.UTF-8]
09-09 12:17:48.579-0500 I/watchface-viewer( 3653): viewer-part-resource.cpp: ThreadCallback(2108) > thread[0xb8032520]
09-09 12:17:48.589-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.589-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateAmPmString(1312) > skeleton[h:mm a] locale[en_US.UTF-8] showAmpmFirst[0]
09-09 12:17:48.589-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.589-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.589-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:48.589-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:48.589-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:48.589-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:48.599-0500 I/watchface-viewer( 3653): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:48.599-0500 E/BASE_UTILS( 3653): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:48.599-0500 I/watchface-viewer( 3653): viewer-util.cpp: Create(864) > created locale[en_US] impl[0xb8025938] refcount[1]
09-09 12:17:48.599-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateAmPmString(1325) > hourString[12] hour[12]
09-09 12:17:48.599-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.599-0500 E/BASE_UTILS( 3653): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:48.599-0500 E/BASE_UTILS( 3653): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:48.599-0500 I/watchface-viewer( 3653): viewer-util.cpp: Destroy(884) > reference decreased locale[en_US] impl[0xb8025938] refcount[0]
09-09 12:17:48.599-0500 I/watchface-viewer( 3653): viewer-util.cpp: Destroy(888) > removed I18NStringUtilityImpl[0xb8025938]
09-09 12:17:48.599-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateAmPmString(1372) > mAm[AM] mPm[PM]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0xb8011808] size(360x231)
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddListener(590) > added listener[0xb8029698] for [13]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddListener(590) > added listener[0xb8011778] for [6]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddListener(590) > added listener[0xb8018d28] for [4]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-group.cpp: Group(97) > Group[0xb802baf8][ambient-time]
09-09 12:17:48.609-0500 E/EFL     ( 3652): elementary<3652> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddDataBroker(1626) > added broker [0xb802a3c8]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-data-broker.cpp: AmbientDataBroker(1389) > AmbientDataBroker[0xb802a3c8]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-part.cpp: Part(84) > Part[0xb802bec8]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-part-resource.cpp: PartResource(67) > PartResource[0xb802ac40]
09-09 12:17:48.609-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:48.609-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:48.609-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:48.609-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-data-broker.cpp: AddListener(1402) > added listener[0xb802b360] for [27]
09-09 12:17:48.609-0500 I/watchface-viewer( 3653): viewer-util.cpp: GetSystemLocale(694) > mLocale[en_US.UTF-8]
09-09 12:17:48.619-0500 E/EFL     ( 3652): elementary<3652> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:48.619-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:48.619-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:48.619-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:48.619-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:48.619-0500 E/EFL     ( 3652): elementary<3652> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:48.619-0500 I/AUL_PAD ( 3652): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateAmPmString(1312) > skeleton[h:mm a] locale[en_US.UTF-8] showAmpmFirst[0]
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.629-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-09 12:17:48.629-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-09 12:17:48.629-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-09 12:17:48.629-0500 E/TIZEN_N_SYSTEM_SETTINGS( 3653): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: UpdateLocale(1043) > mLocale[en_US]
09-09 12:17:48.629-0500 E/BASE_UTILS( 3653): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: Create(864) > created locale[en_US] impl[0xb8019be8] refcount[1]
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateAmPmString(1325) > hourString[12] hour[12]
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: FromUTF8(1166) > empty string!!
09-09 12:17:48.629-0500 E/BASE_UTILS( 3653): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:48.629-0500 E/BASE_UTILS( 3653): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: Destroy(884) > reference decreased locale[en_US] impl[0xb8019be8] refcount[0]
09-09 12:17:48.629-0500 I/watchface-viewer( 3653): viewer-util.cpp: Destroy(888) > removed I18NStringUtilityImpl[0xb8019be8]
09-09 12:17:48.639-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateAmPmString(1372) > mAm[AM] mPm[PM]
09-09 12:17:48.639-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0xb801fae0] size(360x231)
09-09 12:17:48.639-0500 I/watchface-viewer( 3653): viewer-data-broker.cpp: AddListener(1402) > added listener[0xb802b1c8] for [13]
09-09 12:17:48.639-0500 I/watchface-viewer( 3653): viewer-data-broker.cpp: AddListener(1402) > added listener[0xb802b1f8] for [6]
09-09 12:17:48.639-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: ConnectModels(1444) > models will be connected later when first resume received!!
09-09 12:17:48.639-0500 I/watchface-viewer( 3653): viewer-parser.cpp: ~ParserWatchfaceData(519) > 
09-09 12:17:48.639-0500 W/WATCH_CORE( 3653): appcore-watch.c: __widget_create(976) > widget_create done
09-09 12:17:48.739-0500 I/WATCH_CORE( 3653): appcore-watch.c: __watch_core_set_metadata(818) > Tick per second: 5
09-09 12:17:48.749-0500 I/WATCH_CORE( 3653): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
09-09 12:17:48.749-0500 W/WATCH_CORE( 3653): appcore-watch.c: __watch_core_set_metadata(845) > Watchface type
09-09 12:17:48.779-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppControl(676) > 
09-09 12:17:48.779-0500 I/watchface-viewer( 3653): viewer-part-resource.cpp: ThreadNotifyCallback(2170) > thread[0xb8032520]
09-09 12:17:48.779-0500 I/watchface-viewer( 3653): viewer-part-resource.cpp: ThreadEndCallback(2206) > thread[0xb8032520]
09-09 12:17:48.789-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:17:48.789-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:17:48.789-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:17:48.789-0500 I/watchface-viewer( 3653): viewer-util.cpp: GetAppId(61) > appId[com.samsung.watchface]
09-09 12:17:48.839-0500 E/EFL     ( 3653): elementary<3653> elm_layout.c:2207 elm_layout_add() could not add 0xb8011d48 as sub object of 0xb8011a58
09-09 12:17:48.849-0500 W/AUL_AMD (  934): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:17:48.849-0500 W/AUL_AMD (  934): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
09-09 12:17:48.879-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: CreateImage(136) > resized 360x231 -> 334x231
09-09 12:17:48.879-0500 E/EFL     ( 3653): edje<3653> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:17:48.889-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateLayout(1257) > colon 30x182 at (152,0)
09-09 12:17:48.889-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:17:48.889-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:17:48.889-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:17:48.889-0500 E/EFL     ( 3653): elementary<3653> elm_layout.c:2207 elm_layout_add() could not add 0xb8012790 as sub object of 0xb8011bd0
09-09 12:17:48.889-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: CreateImage(136) > resized 360x231 -> 334x231
09-09 12:17:48.889-0500 E/EFL     ( 3653): edje<3653> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:17:48.909-0500 W/WATCH_CORE( 3653): appcore-watch.c: __widget_resume(1012) > widget_resume
09-09 12:17:48.939-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppResume(721) > 
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [27]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [13]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [6]
09-09 12:17:48.939-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:17:48.939-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppResume(728) > mFirstResumeDone
09-09 12:17:48.939-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:48.949-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:48.949-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:48.949-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [1] to pending list
09-09 12:17:48.949-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:48.949-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [2] to pending list
09-09 12:17:48.949-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:17:48.969-0500 W/W_HOME  ( 1143): clock_view.c: clock_view_attach(552) > changed pause/resume option -> manual
09-09 12:17:48.969-0500 I/watchface-viewer( 3653): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
09-09 12:17:48.969-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnLoadingDone(808) > 
09-09 12:17:48.969-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnLoadingDone(811) > idle_watch = [com.samsung.watchface]
09-09 12:17:48.969-0500 W/W_HOME  ( 1143): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
09-09 12:17:48.969-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnLoadingDone(819) > idle_watch = [com.samsung.watchface]
09-09 12:17:48.969-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watch-face-editor:watch-face-editor::localport]
09-09 12:17:48.969-0500 E/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:48.969-0500 E/MESSAGE_PORT( 3653): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (watch-face-editor::localport) is not found.
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.clocksetting.clock:clocksetting::localport]
09-09 12:17:48.969-0500 E/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:48.969-0500 E/MESSAGE_PORT( 3653): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (clocksetting::localport) is not found.
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:w-home::localport]
09-09 12:17:48.969-0500 E/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:17:48.969-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:48.969-0500 E/MESSAGE_PORT( 3653): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (w-home::localport) is not found.
09-09 12:17:48.969-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnLoadingDone(856) > mFirstLoadingDone
09-09 12:17:48.979-0500 W/W_HOME  ( 1143): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
09-09 12:17:48.979-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:48.979-0500 W/W_HOME  ( 1143): clock_view.c: clock_view_attach(569) > changed pause/resume option -> automatic
09-09 12:17:48.979-0500 W/W_HOME  ( 1143): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
09-09 12:17:48.979-0500 E/W_HOME  ( 1143): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
09-09 12:17:48.979-0500 E/W_HOME  ( 1143): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
09-09 12:17:48.999-0500 E/W_HOME  ( 1143): dbox.c: del_cb(231) > Add viewer has no info: org.solemntree.romannumeralwatch
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_service.c: clock_service_event_handler(821) > scroller freeze off
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6e7c92f
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
09-09 12:17:48.999-0500 E/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(563) > com.samsung.watchface is already attached to home
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): cfwd.c: cfwd_get_icon_status(362) > 
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): ============================
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): multi_sim_category:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): multi_sim_model:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): support_callforward_auto:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): conn_status:16
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): remote_call_forward_auto:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): auto_call_forward_status:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): support_callforward_reverse:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): reverse_call_forward_auto:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): fwd_type:ARS
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): ============================
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): 
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(374) > network status : 0
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(379) > sap_connected : 1
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(385) > sap connectivity type : 16
09-09 12:17:48.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(391) > network status : 2
09-09 12:17:49.009-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(398) > svc type : 7
09-09 12:17:49.009-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(405) > scs login : 1
09-09 12:17:49.009-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(433) > network connection via WIFI : no checking svc_type
09-09 12:17:49.009-0500 E/W_HOME  ( 1143): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:17:49.009-0500 W/W_HOME  ( 1143): noti_broker.c: _clock_attached_cb(809) > 0
09-09 12:17:49.009-0500 W/W_HOME  ( 1143): cs_broker.c: _clock_view_attached_cb(231) > 
09-09 12:17:49.009-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
09-09 12:17:49.009-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
09-09 12:17:49.109-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:49.109-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [3]
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [3] to pending list
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [4]
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [4] to pending list
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [5]
09-09 12:17:49.109-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [5] to pending list
09-09 12:17:49.129-0500 E/W_HOME  ( 1143): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
09-09 12:17:49.289-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:49.289-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:49.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:49.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:49.309-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnDummyModeOffTimerExpired(392) > disable dummy mode
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-impl.cpp: SetDummyMode(96) > dummyMode[0]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [1]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [2]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [3]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [4]
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: Notify(984) > skip first tick after resume!!
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [5]
09-09 12:17:49.309-0500 E/EFL     ( 3653): elementary<3653> elm_layout.c:2207 elm_layout_add() could not add 0xb80131d8 as sub object of 0xb8011a58
09-09 12:17:49.309-0500 E/EFL     ( 3653): edje<3653> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:17:49.309-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: UpdateLayout(1257) > colon 30x182 at (152,0)
09-09 12:17:49.319-0500 I/watchface-viewer( 3653): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
09-09 12:17:49.469-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:49.469-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:49.659-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:49.659-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:49.829-0500 I/watchface-viewer( 3653): viewer-view.cpp: DummyModeAnimationFinished(360) > 
09-09 12:17:49.839-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:49.839-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:49.989-0500 W/SNL_W   ( 1705): <checkTimeStamp:264> checkTimeStamp delete timestamp ( 1473441170 ) of conn_id( 1 ) - Current ( 1473441470 )
09-09 12:17:49.989-0500 W/SNL_W   ( 1705): <d2d_timeout_notify_callback:428> d2d_timeout_notify - begin conn_id ( 1 )
09-09 12:17:49.989-0500 W/SCSD    ( 1705): <on_d2dTimeoutNotify:522> conn_id: 1
09-09 12:17:49.989-0500 W/SCSD    ( 1705): <_disconnected_cb:492> SCS Peer Disconnected !!!
09-09 12:17:49.989-0500 W/SCSD    ( 1705): <_disconnected_cb:493>  - conn_id: 1
09-09 12:17:49.989-0500 W/SCSD    ( 1705): <util_dbus_set_connection_status:267> set connection_status: 0
09-09 12:17:49.989-0500 W/SNL_W   ( 1705): <d2d_timeout_notify_callback:430> d2d_timeout_notify - end conn_id ( 1 )
09-09 12:17:49.989-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: close - Call ConnID( 1 ), Timeout ( 1 )
09-09 12:17:49.989-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: release_conn(1) read(3072), sent(107320)
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(374) > network status : 0
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(379) > sap_connected : 1
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(385) > sap connectivity type : 16
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(391) > network status : 2
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(398) > svc type : 7
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(405) > scs login : 1
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(433) > network connection via WIFI : no checking svc_type
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
09-09 12:17:49.999-0500 W/W_HOME  ( 1143): clock_indicator.c: clock_indicator_pop(370) > icon:5(0) is popped from clock indicator
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
09-09 12:17:49.999-0500 I/W_INDICATOR( 1093): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(95) > [windicator_scs_update:95] svc type : 7
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
09-09 12:17:49.999-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 0
09-09 12:17:50.009-0500 I/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
09-09 12:17:50.029-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:50.029-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:50.029-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: StartColonAnimation(1501) > 
09-09 12:17:50.029-0500 I/watchface-viewer( 3653): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
09-09 12:17:50.199-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103626726f6d147344146
