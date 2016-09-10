S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3610
Date: 2016-09-09 12:17:44-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbee61e64, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbee61930, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb42484d0
r10  = 0x0000000c, fp   = 0xbee61924
ip   = 0x0000000c, sp   = 0xbee613b0
lr   = 0xb6b7af5c, pc   = 0xb6bb56dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:      7072 KB
Buffers:      8904 KB
Cached:      90072 KB
VmPeak:      63188 KB
VmSize:      62644 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13420 KB
VmRSS:       13420 KB
VmData:      12696 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       45884 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3610 TID = 3610
3610 3613 

Maps Information
b352e000 b35ba000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b35ba000 b35c9000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b35c9000 b35e0000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b35e8000 b35ed000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b35ed000 b378c000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b378c000 b3813000 rwxs anon_inode:dmabuf
b3813000 b381e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3826000 b3827000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3827000 b3829000 r-xp /usr/lib/libgenlock.so
b3830000 b3831000 rwxp /usr/lib/libgenlock.so
b3831000 b3835000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b3835000 b383c000 r-xs /usr/lib/gconv/gconv-modules.cache
b383c000 b383f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3846000 b3847000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3848000 b4047000 rwxp [stack:3613]
b4047000 b4247000 r-xp /usr/share/locale/locale-archive
b424c000 b424f000 r-xp /lib/libattr.so.1.1.0
b4256000 b4257000 rwxp /lib/libattr.so.1.1.0
b4257000 b4259000 r-xp /usr/lib/libXau.so.6.0.0
b4260000 b4261000 rwxp /usr/lib/libXau.so.6.0.0
b4262000 b4264000 r-xp /usr/lib/libiniparser.so.0
b426c000 b426d000 rwxp /usr/lib/libiniparser.so.0
b426d000 b4274000 r-xp /lib/libcrypt-2.13.so
b427b000 b427c000 r-xp /lib/libcrypt-2.13.so
b427c000 b427d000 rwxp /lib/libcrypt-2.13.so
b42a4000 b42a7000 r-xp /lib/libcap.so.2.21
b42ae000 b42af000 rwxp /lib/libcap.so.2.21
b42af000 b42b1000 r-xp /usr/lib/libiri.so
b42b8000 b42b9000 rwxp /usr/lib/libiri.so
b42b9000 b42c4000 r-xp /usr/lib/libgpg-error.so.0.15.0
b42cb000 b42cc000 rwxp /usr/lib/libgpg-error.so.0.15.0
b42cd000 b4475000 r-xp /usr/lib/libcrypto.so.1.0.0
b4475000 b448a000 rwxp /usr/lib/libcrypto.so.1.0.0
b448e000 b44db000 r-xp /usr/lib/libssl.so.1.0.0
b44e2000 b44e7000 rwxp /usr/lib/libssl.so.1.0.0
b44e7000 b4515000 r-xp /usr/lib/libidn.so.11.5.44
b451c000 b451d000 rwxp /usr/lib/libidn.so.11.5.44
b451d000 b4526000 r-xp /usr/lib/libcares.so.2.1.0
b452e000 b452f000 rwxp /usr/lib/libcares.so.2.1.0
b4530000 b4543000 r-xp /usr/lib/libxcb.so.1.1.0
b454b000 b454c000 rwxp /usr/lib/libxcb.so.1.1.0
b454c000 b4553000 r-xp /usr/lib/libtbm.so.1.0.0
b455a000 b455b000 rwxp /usr/lib/libtbm.so.1.0.0
b455b000 b455d000 r-xp /usr/lib/libdri2.so.0.0.0
b4564000 b4565000 rwxp /usr/lib/libdri2.so.0.0.0
b4565000 b456a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4571000 b4572000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b4572000 b457a000 r-xp /usr/lib/libdrm.so.2.4.0
b4581000 b4582000 rwxp /usr/lib/libdrm.so.2.4.0
b4583000 b4585000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b458c000 b458d000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b458d000 b458f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4597000 b4598000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b4598000 b4664000 r-xp /usr/lib/libxml2.so.2.7.8
b466b000 b4670000 rwxp /usr/lib/libxml2.so.2.7.8
b4671000 b468e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4696000 b4697000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b4697000 b469a000 r-xp /usr/lib/libsmack.so.1.0.0
b46a1000 b46a2000 rwxp /usr/lib/libsmack.so.1.0.0
b46a3000 b46a5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b46ac000 b46ad000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b46ad000 b46bd000 r-xp /lib/libresolv-2.13.so
b46bd000 b46be000 r-xp /lib/libresolv-2.13.so
b46be000 b46bf000 rwxp /lib/libresolv-2.13.so
b46c1000 b473d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b4744000 b4749000 rwxp /usr/lib/libgcrypt.so.20.0.3
b4749000 b4761000 r-xp /usr/lib/liblzma.so.5.0.3
b4768000 b4769000 rwxp /usr/lib/liblzma.so.5.0.3
b4769000 b4781000 r-xp /usr/lib/libpng12.so.0.50.0
b4788000 b4789000 rwxp /usr/lib/libpng12.so.0.50.0
b478a000 b47a0000 r-xp /lib/libexpat.so.1.5.2
b47a8000 b47aa000 rwxp /lib/libexpat.so.1.5.2
b47aa000 b47ee000 r-xp /usr/lib/libcurl.so.4.3.0
b47f5000 b47f7000 rwxp /usr/lib/libcurl.so.4.3.0
b47f7000 b4801000 r-xp /usr/lib/libXext.so.6.4.0
b4809000 b480a000 rwxp /usr/lib/libXext.so.6.4.0
b480a000 b480e000 r-xp /usr/lib/libXtst.so.6.1.0
b4815000 b4816000 rwxp /usr/lib/libXtst.so.6.1.0
b4816000 b481c000 r-xp /usr/lib/libXrender.so.1.3.0
b4823000 b4824000 rwxp /usr/lib/libXrender.so.1.3.0
b4825000 b482b000 r-xp /usr/lib/libXrandr.so.2.2.0
b4832000 b4833000 rwxp /usr/lib/libXrandr.so.2.2.0
b4833000 b4834000 r-xp /usr/lib/libXinerama.so.1.0.0
b483c000 b483d000 rwxp /usr/lib/libXinerama.so.1.0.0
b483d000 b4846000 r-xp /usr/lib/libXi.so.6.1.0
b484d000 b484e000 rwxp /usr/lib/libXi.so.6.1.0
b484e000 b4851000 r-xp /usr/lib/libXfixes.so.3.1.0
b4858000 b4859000 rwxp /usr/lib/libXfixes.so.3.1.0
b4859000 b485b000 r-xp /usr/lib/libXgesture.so.7.0.0
b4862000 b4863000 rwxp /usr/lib/libXgesture.so.7.0.0
b4863000 b4865000 r-xp /usr/lib/libXcomposite.so.1.0.0
b486c000 b486d000 rwxp /usr/lib/libXcomposite.so.1.0.0
b486e000 b4870000 r-xp /usr/lib/libXdamage.so.1.1.0
b4877000 b4878000 rwxp /usr/lib/libXdamage.so.1.1.0
b4878000 b487f000 r-xp /usr/lib/libXcursor.so.1.0.2
b4886000 b4887000 rwxp /usr/lib/libXcursor.so.1.0.2
b4887000 b4888000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b488f000 b4890000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b4890000 b4896000 r-xp /usr/lib/libecore_imf.so.1.7.99
b489d000 b489e000 rwxp /usr/lib/libecore_imf.so.1.7.99
b489e000 b48b5000 r-xp /usr/lib/liblua-5.1.so
b48bd000 b48be000 rwxp /usr/lib/liblua-5.1.so
b48bf000 b48c6000 r-xp /usr/lib/libembryo.so.1.7.99
b48cd000 b48ce000 rwxp /usr/lib/libembryo.so.1.7.99
b48ce000 b48d1000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b48d8000 b48d9000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b48d9000 b48dd000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b48e5000 b48e6000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b48e6000 b48eb000 r-xp /usr/lib/libecore_fb.so.1.7.99
b48f2000 b48f4000 rwxp /usr/lib/libecore_fb.so.1.7.99
b48f4000 b4917000 r-xp /usr/lib/libjpeg.so.8.0.2
b491e000 b491f000 rwxp /usr/lib/libjpeg.so.8.0.2
b4930000 b4946000 r-xp /lib/libz.so.1.2.5
b494d000 b494e000 rwxp /lib/libz.so.1.2.5
b494e000 b4a2f000 r-xp /usr/lib/libX11.so.6.3.0
b4a36000 b4a3a000 rwxp /usr/lib/libX11.so.6.3.0
b4a3a000 b4a43000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4a4b000 b4a4c000 rwxp /usr/lib/libwidget_provider.so.1.0.0
b4a4c000 b4a52000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b4a5a000 b4a5b000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b4a5b000 b4a67000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4a6e000 b4a6f000 rwxp /usr/lib/libwidget_service.so.1.0.0
b4a70000 b4a79000 r-xp /usr/lib/libcom-core.so.0.0.1
b4a81000 b4a82000 rwxp /usr/lib/libcom-core.so.0.0.1
b4a82000 b6001000 r-xp /usr/lib/libicudata.so.51.1
b6008000 b6009000 rwxp /usr/lib/libicudata.so.51.1
b6009000 b609d000 r-xp /usr/lib/libstdc++.so.6.0.16
b60a5000 b60a8000 r-xp /usr/lib/libstdc++.so.6.0.16
b60a8000 b60aa000 rwxp /usr/lib/libstdc++.so.6.0.16
b60b0000 b6125000 r-xp /usr/lib/libsqlite3.so.0.8.6
b612c000 b612f000 rwxp /usr/lib/libsqlite3.so.0.8.6
b612f000 b6145000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b614c000 b614d000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b614e000 b6153000 r-xp /usr/lib/libffi.so.5.0.10
b615a000 b615b000 rwxp /usr/lib/libffi.so.5.0.10
b615b000 b6161000 r-xp /lib/librt-2.13.so
b6168000 b6169000 r-xp /lib/librt-2.13.so
b6169000 b616a000 rwxp /lib/librt-2.13.so
b616a000 b616b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6172000 b6173000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6173000 b6179000 r-xp /usr/lib/libappsvc.so.0.1.0
b6180000 b6181000 rwxp /usr/lib/libappsvc.so.0.1.0
b6181000 b61ae000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b61b5000 b61b6000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b61b7000 b628a000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6291000 b6295000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6295000 b6298000 r-xp /usr/lib/libproc-stat.so.0.2.86
b629f000 b62a0000 rwxp /usr/lib/libproc-stat.so.0.2.86
b62a0000 b62dc000 r-xp /usr/lib/libsystemd.so.0.4.0
b62e3000 b62e4000 r-xp /usr/lib/libsystemd.so.0.4.0
b62e4000 b62e5000 rwxp /usr/lib/libsystemd.so.0.4.0
b62e5000 b62ea000 r-xp /usr/lib/libxdgmime.so.1.1.0
b62f1000 b62f2000 rwxp /usr/lib/libxdgmime.so.1.1.0
b62f2000 b62f5000 r-xp /usr/lib/libbundle.so.0.1.22
b62fc000 b62fd000 rwxp /usr/lib/libbundle.so.0.1.22
b62fe000 b6354000 r-xp /usr/lib/libpixman-1.so.0.28.2
b635c000 b6361000 rwxp /usr/lib/libpixman-1.so.0.28.2
b6361000 b63b7000 r-xp /usr/lib/libfreetype.so.6.11.3
b63bf000 b63c3000 rwxp /usr/lib/libfreetype.so.6.11.3
b63c3000 b63eb000 r-xp /usr/lib/libfontconfig.so.1.8.0
b63eb000 b63ec000 rwxp /usr/lib/libfontconfig.so.1.8.0
b63ec000 b6429000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6430000 b6431000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b6432000 b6445000 r-xp /usr/lib/libfribidi.so.0.3.1
b644c000 b644d000 rwxp /usr/lib/libfribidi.so.0.3.1
b644e000 b6468000 r-xp /usr/lib/libecore_con.so.1.7.99
b646f000 b6470000 rwxp /usr/lib/libecore_con.so.1.7.99
b6471000 b647a000 r-xp /usr/lib/libedbus.so.1.7.99
b6481000 b6482000 rwxp /usr/lib/libedbus.so.1.7.99
b6482000 b64d2000 r-xp /usr/lib/libecore_x.so.1.7.99
b64d2000 b64d4000 rwxp /usr/lib/libecore_x.so.1.7.99
b64d4000 b6531000 r-xp /usr/lib/libedje.so.1.7.99
b6539000 b653b000 rwxp /usr/lib/libedje.so.1.7.99
b653b000 b654c000 r-xp /usr/lib/libecore_input.so.1.7.99
b6553000 b6554000 rwxp /usr/lib/libecore_input.so.1.7.99
b6554000 b6559000 r-xp /usr/lib/libecore_file.so.1.7.99
b6560000 b6561000 rwxp /usr/lib/libecore_file.so.1.7.99
b6562000 b6584000 r-xp /usr/lib/libecore_evas.so.1.7.99
b658b000 b658d000 rwxp /usr/lib/libecore_evas.so.1.7.99
b658d000 b65a6000 r-xp /usr/lib/libeet.so.1.7.99
b65ae000 b65af000 rwxp /usr/lib/libeet.so.1.7.99
b65b7000 b6620000 r-xp /lib/libm-2.13.so
b6627000 b6628000 r-xp /lib/libm-2.13.so
b6628000 b6629000 rwxp /lib/libm-2.13.so
b6629000 b662f000 r-xp /usr/lib/libwidget.so.1.0.0
b6637000 b6638000 rwxp /usr/lib/libwidget.so.1.0.0
b6638000 b663e000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b6645000 b6646000 rwxp /usr/lib/libwidget_provider_app.so.1.0.0
b6646000 b6670000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6678000 b6679000 rwxp /usr/lib/libdbus-1.so.3.8.12
b6679000 b6749000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6749000 b674a000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b674a000 b674e000 r-xp /usr/lib/libvconf.so.0.2.45
b6755000 b6756000 rwxp /usr/lib/libvconf.so.0.2.45
b6756000 b683a000 r-xp /usr/lib/libicuuc.so.51.1
b6841000 b684b000 rwxp /usr/lib/libicuuc.so.51.1
b684f000 b698c000 r-xp /usr/lib/libicui18n.so.51.1
b6994000 b699c000 rwxp /usr/lib/libicui18n.so.51.1
b699c000 b69dd000 r-xp /usr/lib/libeina.so.1.7.99
b69e4000 b69e6000 rwxp /usr/lib/libeina.so.1.7.99
b69e6000 b69fd000 r-xp /usr/lib/libecore.so.1.7.99
b6a05000 b6a06000 rwxp /usr/lib/libecore.so.1.7.99
b6a14000 b6a36000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a3d000 b6a3e000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a3e000 b6a42000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6a4a000 b6a4b000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6a4b000 b6a5f000 r-xp /lib/libpthread-2.13.so
b6a66000 b6a67000 r-xp /lib/libpthread-2.13.so
b6a67000 b6a68000 rwxp /lib/libpthread-2.13.so
b6a6a000 b6a9e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6aa5000 b6aa7000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6aa7000 b6ab4000 r-xp /usr/lib/libalarm.so.0.0.0
b6abb000 b6abd000 rwxp /usr/lib/libalarm.so.0.0.0
b6abd000 b6ad4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6adb000 b6adc000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6adc000 b6ae8000 r-xp /usr/lib/libaul.so.0.1.0
b6af0000 b6af1000 rwxp /usr/lib/libaul.so.0.1.0
b6af2000 b6afa000 r-xp /lib/libgcc_s-4.6.so.1
b6afa000 b6afb000 rwxp /lib/libgcc_s-4.6.so.1
b6afb000 b6afd000 r-xp /lib/libdl-2.13.so
b6b04000 b6b05000 r-xp /lib/libdl-2.13.so
b6b05000 b6b06000 rwxp /lib/libdl-2.13.so
b6b06000 b6b11000 r-xp /lib/libunwind.so.8.0.1
b6b18000 b6b19000 rwxp /lib/libunwind.so.8.0.1
b6b3e000 b6c59000 r-xp /lib/libc-2.13.so
b6c61000 b6c63000 r-xp /lib/libc-2.13.so
b6c63000 b6c64000 rwxp /lib/libc-2.13.so
b6c67000 b6d35000 r-xp /usr/lib/libevas.so.1.7.99
b6d3d000 b6d47000 rwxp /usr/lib/libevas.so.1.7.99
b6d5a000 b6e95000 r-xp /usr/lib/libelementary.so.1.7.99
b6e9c000 b6ea4000 rwxp /usr/lib/libelementary.so.1.7.99
b6eab000 b6ead000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb4000 b6eb5000 rwxp /usr/lib/libdlog.so.0.0.0
b6eb5000 b6eb7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6ebf000 b6ec0000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6ec0000 b6ec7000 r-xp /usr/lib/libappcore-watch.so.1.1
b6ecf000 b6ed0000 rwxp /usr/lib/libappcore-watch.so.1.1
b6ed0000 b6ed3000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b6ed3000 b6ed5000 r-xp /usr/share/locale/en/LC_MESSAGES/elementary.mo
b6ed5000 b6ed7000 r-xp /usr/share/locale/en_US/LC_MESSAGES/elementary.mo
b6ed8000 b6edd000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6ee4000 b6ee5000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6ee5000 b6ee6000 r-xp /usr/share/locale/locale-archive
b6ee6000 b6eea000 r-xp /usr/lib/libsys-assert.so
b6ef2000 b6ef3000 rwxp /usr/lib/libsys-assert.so
b6ef3000 b6f10000 r-xp /lib/ld-2.13.so
b6f17000 b6f18000 r-xp /lib/ld-2.13.so
b6f18000 b6f19000 rwxp /lib/ld-2.13.so
b6f19000 b6f1b000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b6f22000 b6f23000 rwxp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b74e6000 b7643000 rwxp [heap]
bee42000 bee63000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3610)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6bb56dc) [/lib/libc.so.6] + 0x776dc
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
ntent size (w, h)(5684, 360)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(12) DetentCount(1)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3134), py(0)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3134), py(0)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3134), py(0)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 16 page
09-09 12:17:40.239-0500 I/GESTURE (  252): gesture.c: GestureHandleMTSyncEvent(3243) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
09-09 12:17:40.329-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xae198248 : elm_scroller] CurrentPage(16)
09-09 12:17:40.659-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918143
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3872), py(0)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3872), py(0)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3872), py(0)
09-09 12:17:40.659-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 17 page
09-09 12:17:40.799-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.809-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.809-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918283
09-09 12:17:40.809-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4054), py(0)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4054), py(0)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4054), py(0)
09-09 12:17:40.819-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 18 page
09-09 12:17:40.919-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918400
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4229), py(0)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4229), py(0)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4229), py(0)
09-09 12:17:40.929-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 19 page
09-09 12:17:40.969-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918454
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4321), py(0)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4321), py(0)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4321), py(0)
09-09 12:17:40.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 20 page
09-09 12:17:41.029-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918514
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4402), py(0)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4402), py(0)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4402), py(0)
09-09 12:17:41.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 21 page
09-09 12:17:41.159-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918644
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4845), py(0)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4845), py(0)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4845), py(0)
09-09 12:17:41.169-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 22 page
09-09 12:17:41.289-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918772
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5147), py(0)
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5147), py(0)
09-09 12:17:41.299-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5147), py(0)
09-09 12:17:41.409-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1918892
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(16) DetentCount(1)
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5314), py(0)
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5314), py(0)
09-09 12:17:41.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5314), py(0)
09-09 12:17:41.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xae198248 : elm_scroller] CurrentPage(22)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1919656
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(22) DetentCount(-1)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5324), py(0)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5324), py(0)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5324), py(0)
09-09 12:17:42.179-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 21 page
09-09 12:17:42.179-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
09-09 12:17:42.459-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xae198248 : elm_scroller] CurrentPage(21)
09-09 12:17:42.939-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_vconf_clocks_set_idle(6474) > ConnectionType[16] is not BT, ignore this callback.
09-09 12:17:42.949-0500 W/W_HOME  ( 1143): rotary.c: rotary_deattach(156) > rotary_deattach:0xae198248
09-09 12:17:42.949-0500 I/efl-extension( 1143): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb89f0d48, elm_box, _activated_obj : 0xae3dda20, activated : 1
09-09 12:17:42.949-0500 I/efl-extension( 1143): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 12:17:42.949-0500 E/wnotib  ( 1143): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
09-09 12:17:42.949-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 38, 14883.
09-09 12:17:42.949-0500 I/wnotib  ( 1143): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
09-09 12:17:42.949-0500 I/MESSAGE_PORT( 1143): MessagePortProxy.cpp: IsLocalPortRegisted(695) > MessagePort name is already registered.
09-09 12:17:42.949-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:42.949-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:42.949-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:42.949-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
09-09 12:17:42.949-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
09-09 12:17:42.949-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:42.949-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.w-home:w-home::localport], client = 1143
09-09 12:17:42.959-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:42.959-0500 E/EFL     ( 1143): edje<1143> edje_util.c:3770 edje_object_size_min_restricted_calc() group page has a non-fixed part 'clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:17:43.029-0500 W/W_HOME  ( 1143): clock_service.c: clock_service_event_handler(821) > scroller freeze off
09-09 12:17:43.029-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6e7c92f
09-09 12:17:43.029-0500 W/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: org.solemntree.romannumeralwatch 1 0 0 1
09-09 12:17:43.029-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:17:43.029-0500 E/W_HOME  ( 1143): clock_service.c: _clock_provider_change(396) > clock will be changed to org.solemntree.romannumeralwatch
09-09 12:17:43.049-0500 E/W_HOME  ( 1143): dbox.c: widget_create(365) > add-viewer info none: org.solemntree.romannumeralwatch
09-09 12:17:43.049-0500 W/W_HOME  ( 1143): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
09-09 12:17:43.049-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
09-09 12:17:43.049-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
09-09 12:17:43.049-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:17:43.049-0500 E/W_HOME  ( 1143): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
09-09 12:17:43.059-0500 E/W_HOME  ( 1143): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
09-09 12:17:43.059-0500 W/W_HOME  ( 1143): cs_broker.c: _wms_clock_vconf_cb(283) > 
09-09 12:17:43.059-0500 E/CLOCK-LIST( 1143): clocklist_main.c: clock_setting_event(3764) > proxy image is not deleted. Ignore event
09-09 12:17:43.059-0500 W/W_HOME  ( 1143): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,will,hide
09-09 12:17:43.059-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:43.059-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:43.059-0500 W/W_HOME  ( 1143): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
09-09 12:17:43.059-0500 W/W_HOME  ( 1143): main.c: home_resume(735) > clock/widget resumed
09-09 12:17:43.109-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
09-09 12:17:43.129-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:43.139-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:43.139-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:17:43.139-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:17:43.149-0500 E/RESOURCED(  935): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.solemntree.romannumeralwatch, table num : 1
09-09 12:17:43.149-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:17:43.159-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:17:43.159-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
09-09 12:17:43.159-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:17:43.179-0500 I/CAPI_WATCH_APPLICATION( 3454): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:17:43.259-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:17:43.259-0500 W/WATCH_CORE( 3368): appcore-watch.c: __widget_resume(1012) > widget_resume
09-09 12:17:43.269-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppResume(721) > 
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [4]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [4]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [4] to pending list
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [6]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [13]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [27]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [1]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [1] to pending list
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [2]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [2] to pending list
09-09 12:17:43.269-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:43.269-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [3]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [3] to pending list
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [4]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [5]
09-09 12:17:43.269-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: AddPendingChanges(1088) > added [5] to pending list
09-09 12:17:43.339-0500 W/WATCH_CORE( 3454): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:17:43.339-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1920.533813] pkgname: org.solemntree.romannumeralwatch, id: file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1920.533813.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:17:43.339-0500 W/W_HOME  ( 1143): dbox.c: _widget_created_cb(244) > widget resume:0xac23a788
09-09 12:17:43.339-0500 E/WIDGET_VIEWER( 1143): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
09-09 12:17:43.359-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
09-09 12:17:43.359-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
09-09 12:17:43.449-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:43.449-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:43.449-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:43.449-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:43.499-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103454726f6d1473441463
09-09 12:17:43.639-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:43.639-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:43.639-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:43.639-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:43.699-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 4
09-09 12:17:43.699-0500 E/AUL_AMD (  934): amd_request.c: __app_process_by_pid(193) > pid(3454) is dead. cmd(4) is canceled
09-09 12:17:43.699-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3454
09-09 12:17:43.699-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
09-09 12:17:43.709-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:43.719-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:43.719-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:17:43.719-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:17:43.729-0500 E/RESOURCED(  935): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.solemntree.romannumeralwatch, table num : 1
09-09 12:17:43.729-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:17:43.729-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:17:43.839-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:43.839-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:43.839-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:43.839-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:44.019-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:44.019-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:44.019-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:44.019-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:44.019-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [3]
09-09 12:17:44.019-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [4]
09-09 12:17:44.019-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [5]
09-09 12:17:44.219-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:44.219-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:44.219-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:44.219-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:44.259-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
09-09 12:17:44.259-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:17:44.269-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2097) > Launch with legacy way : no launchpad
09-09 12:17:44.269-0500 W/AUL_AMD (  934): amd_launch.c: start_process(580) > child process: 3610
09-09 12:17:44.269-0500 E/RESOURCED( 1536): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
09-09 12:17:44.269-0500 E/AUL     ( 1536): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
09-09 12:17:44.269-0500 E/CAPI_APPFW_APP_MANAGER( 1536): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 12:17:44.349-0500 W/AUL_AMD (  934): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3610
09-09 12:17:44.349-0500 W/AUL_AMD (  934): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:17:44.349-0500 W/AUL_AMD (  934): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
09-09 12:17:44.349-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:17:44.369-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:44.369-0500 I/CAPI_WATCH_APPLICATION( 3610): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:17:44.379-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3610
09-09 12:17:44.379-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:17:44.409-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:44.409-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:44.409-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:44.409-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:44.409-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:44.409-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:44.429-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:44.439-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:44.469-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:44.469-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:44.469-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:44.469-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:44.469-0500 E/EFL     ( 3610): elementary<3610> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:44.499-0500 E/EFL     ( 3610): elementary<3610> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:44.499-0500 E/EFL     ( 3610): elementary<3610> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:44.499-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:44.519-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:44.519-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:44.569-0500 I/RESOURCED(  935): vmpressure-lowmem-handler.c: change_lowmem_state(1098) > [change_lowmem_state,1098] [LOW MEM STATE] mem normal ==> mem swap
09-09 12:17:44.569-0500 I/RESOURCED(  935): vmpressure-lowmem-handler.c: adjust_dynamic_threshold(322) > [adjust_dynamic_threshold,322] dynamic_threshold is changed from 50 to 50, cur_mem_state = mem swap, victim_memcg = 5
09-09 12:17:44.579-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:44.589-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:44.609-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:44.609-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:44.609-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:44.609-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:44.609-0500 E/EFL     ( 3610): elementary<3610> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:44.619-0500 E/EFL     ( 3610): elementary<3610> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:44.619-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:44.619-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:44.619-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:44.619-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:44.619-0500 E/EFL     ( 3610): elementary<3610> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:44.659-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:44.659-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:44.659-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:44.659-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:44.659-0500 E/EFL     ( 3609): elementary<3609> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:44.689-0500 W/WATCH_CORE( 3610): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:17:44.699-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1920.533813] pkgname: org.solemntree.romannumeralwatch, id: file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1920.533813.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://23068728:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:17:44.699-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[1920.533813] pkgname[org.solemntree.romannumeralwatch], id[file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1920.533813.png] content[] cluster[user,created] category[default] widget_fname[pixmap://23068728:4] gbar_fname[]
09-09 12:17:44.709-0500 E/EFL     ( 3609): elementary<3609> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:44.719-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
09-09 12:17:44.719-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
09-09 12:17:44.719-0500 E/EFL     ( 3609): elementary<3609> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:44.729-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:44.809-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:44.809-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:44.809-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:44.809-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:44.899-0500 E/EFL     ( 3609): elementary<3609> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:44.899-0500 E/EFL     ( 3609): elementary<3609> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:44.909-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:44.909-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:44.909-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:44.909-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:44.909-0500 E/EFL     ( 3609): elementary<3609> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:44.919-0500 I/AUL_PAD ( 3609): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:17:44.959-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103610726f6d147344146
