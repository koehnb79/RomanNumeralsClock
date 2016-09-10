S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3369
Date: 2016-09-09 12:17:26-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbee2ce64, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbee2c930, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb43014d0
r10  = 0x0000000c, fp   = 0xbee2c924
ip   = 0x0000000c, sp   = 0xbee2c3b0
lr   = 0xb6c33f5c, pc   = 0xb6c6e6dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:     16152 KB
Buffers:     10428 KB
Cached:      97288 KB
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
PID = 3369 TID = 3369
3369 3376 

Maps Information
b35e7000 b3673000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b3673000 b3682000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b3682000 b3699000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b36a1000 b36a6000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b36a6000 b3845000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b3845000 b38cc000 rwxs anon_inode:dmabuf
b38cc000 b38d7000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b38df000 b38e0000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b38e0000 b38e2000 r-xp /usr/lib/libgenlock.so
b38e9000 b38ea000 rwxp /usr/lib/libgenlock.so
b38ea000 b38ee000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b38ee000 b38f5000 r-xs /usr/lib/gconv/gconv-modules.cache
b38f5000 b38f8000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b38ff000 b3900000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3901000 b4100000 rwxp [stack:3376]
b4100000 b4300000 r-xp /usr/share/locale/locale-archive
b4305000 b4308000 r-xp /lib/libattr.so.1.1.0
b430f000 b4310000 rwxp /lib/libattr.so.1.1.0
b4310000 b4312000 r-xp /usr/lib/libXau.so.6.0.0
b4319000 b431a000 rwxp /usr/lib/libXau.so.6.0.0
b431b000 b431d000 r-xp /usr/lib/libiniparser.so.0
b4325000 b4326000 rwxp /usr/lib/libiniparser.so.0
b4326000 b432d000 r-xp /lib/libcrypt-2.13.so
b4334000 b4335000 r-xp /lib/libcrypt-2.13.so
b4335000 b4336000 rwxp /lib/libcrypt-2.13.so
b435d000 b4360000 r-xp /lib/libcap.so.2.21
b4367000 b4368000 rwxp /lib/libcap.so.2.21
b4368000 b436a000 r-xp /usr/lib/libiri.so
b4371000 b4372000 rwxp /usr/lib/libiri.so
b4372000 b437d000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4384000 b4385000 rwxp /usr/lib/libgpg-error.so.0.15.0
b4386000 b452e000 r-xp /usr/lib/libcrypto.so.1.0.0
b452e000 b4543000 rwxp /usr/lib/libcrypto.so.1.0.0
b4547000 b4594000 r-xp /usr/lib/libssl.so.1.0.0
b459b000 b45a0000 rwxp /usr/lib/libssl.so.1.0.0
b45a0000 b45ce000 r-xp /usr/lib/libidn.so.11.5.44
b45d5000 b45d6000 rwxp /usr/lib/libidn.so.11.5.44
b45d6000 b45df000 r-xp /usr/lib/libcares.so.2.1.0
b45e7000 b45e8000 rwxp /usr/lib/libcares.so.2.1.0
b45e9000 b45fc000 r-xp /usr/lib/libxcb.so.1.1.0
b4604000 b4605000 rwxp /usr/lib/libxcb.so.1.1.0
b4605000 b460c000 r-xp /usr/lib/libtbm.so.1.0.0
b4613000 b4614000 rwxp /usr/lib/libtbm.so.1.0.0
b4614000 b4616000 r-xp /usr/lib/libdri2.so.0.0.0
b461d000 b461e000 rwxp /usr/lib/libdri2.so.0.0.0
b461e000 b4623000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b462a000 b462b000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b462b000 b4633000 r-xp /usr/lib/libdrm.so.2.4.0
b463a000 b463b000 rwxp /usr/lib/libdrm.so.2.4.0
b463c000 b463e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b4645000 b4646000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b4646000 b4648000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4650000 b4651000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b4651000 b471d000 r-xp /usr/lib/libxml2.so.2.7.8
b4724000 b4729000 rwxp /usr/lib/libxml2.so.2.7.8
b472a000 b4747000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b474f000 b4750000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b4750000 b4753000 r-xp /usr/lib/libsmack.so.1.0.0
b475a000 b475b000 rwxp /usr/lib/libsmack.so.1.0.0
b475c000 b475e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4765000 b4766000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b4766000 b4776000 r-xp /lib/libresolv-2.13.so
b4776000 b4777000 r-xp /lib/libresolv-2.13.so
b4777000 b4778000 rwxp /lib/libresolv-2.13.so
b477a000 b47f6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b47fd000 b4802000 rwxp /usr/lib/libgcrypt.so.20.0.3
b4802000 b481a000 r-xp /usr/lib/liblzma.so.5.0.3
b4821000 b4822000 rwxp /usr/lib/liblzma.so.5.0.3
b4822000 b483a000 r-xp /usr/lib/libpng12.so.0.50.0
b4841000 b4842000 rwxp /usr/lib/libpng12.so.0.50.0
b4843000 b4859000 r-xp /lib/libexpat.so.1.5.2
b4861000 b4863000 rwxp /lib/libexpat.so.1.5.2
b4863000 b48a7000 r-xp /usr/lib/libcurl.so.4.3.0
b48ae000 b48b0000 rwxp /usr/lib/libcurl.so.4.3.0
b48b0000 b48ba000 r-xp /usr/lib/libXext.so.6.4.0
b48c2000 b48c3000 rwxp /usr/lib/libXext.so.6.4.0
b48c3000 b48c7000 r-xp /usr/lib/libXtst.so.6.1.0
b48ce000 b48cf000 rwxp /usr/lib/libXtst.so.6.1.0
b48cf000 b48d5000 r-xp /usr/lib/libXrender.so.1.3.0
b48dc000 b48dd000 rwxp /usr/lib/libXrender.so.1.3.0
b48de000 b48e4000 r-xp /usr/lib/libXrandr.so.2.2.0
b48eb000 b48ec000 rwxp /usr/lib/libXrandr.so.2.2.0
b48ec000 b48ed000 r-xp /usr/lib/libXinerama.so.1.0.0
b48f5000 b48f6000 rwxp /usr/lib/libXinerama.so.1.0.0
b48f6000 b48ff000 r-xp /usr/lib/libXi.so.6.1.0
b4906000 b4907000 rwxp /usr/lib/libXi.so.6.1.0
b4907000 b490a000 r-xp /usr/lib/libXfixes.so.3.1.0
b4911000 b4912000 rwxp /usr/lib/libXfixes.so.3.1.0
b4912000 b4914000 r-xp /usr/lib/libXgesture.so.7.0.0
b491b000 b491c000 rwxp /usr/lib/libXgesture.so.7.0.0
b491c000 b491e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b4925000 b4926000 rwxp /usr/lib/libXcomposite.so.1.0.0
b4927000 b4929000 r-xp /usr/lib/libXdamage.so.1.1.0
b4930000 b4931000 rwxp /usr/lib/libXdamage.so.1.1.0
b4931000 b4938000 r-xp /usr/lib/libXcursor.so.1.0.2
b493f000 b4940000 rwxp /usr/lib/libXcursor.so.1.0.2
b4940000 b4941000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4948000 b4949000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b4949000 b494f000 r-xp /usr/lib/libecore_imf.so.1.7.99
b4956000 b4957000 rwxp /usr/lib/libecore_imf.so.1.7.99
b4957000 b496e000 r-xp /usr/lib/liblua-5.1.so
b4976000 b4977000 rwxp /usr/lib/liblua-5.1.so
b4978000 b497f000 r-xp /usr/lib/libembryo.so.1.7.99
b4986000 b4987000 rwxp /usr/lib/libembryo.so.1.7.99
b4987000 b498a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4991000 b4992000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b4992000 b4996000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b499e000 b499f000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b499f000 b49a4000 r-xp /usr/lib/libecore_fb.so.1.7.99
b49ab000 b49ad000 rwxp /usr/lib/libecore_fb.so.1.7.99
b49ad000 b49d0000 r-xp /usr/lib/libjpeg.so.8.0.2
b49d7000 b49d8000 rwxp /usr/lib/libjpeg.so.8.0.2
b49e9000 b49ff000 r-xp /lib/libz.so.1.2.5
b4a06000 b4a07000 rwxp /lib/libz.so.1.2.5
b4a07000 b4ae8000 r-xp /usr/lib/libX11.so.6.3.0
b4aef000 b4af3000 rwxp /usr/lib/libX11.so.6.3.0
b4af3000 b4afc000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4b04000 b4b05000 rwxp /usr/lib/libwidget_provider.so.1.0.0
b4b05000 b4b0b000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b4b13000 b4b14000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b4b14000 b4b20000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4b27000 b4b28000 rwxp /usr/lib/libwidget_service.so.1.0.0
b4b29000 b4b32000 r-xp /usr/lib/libcom-core.so.0.0.1
b4b3a000 b4b3b000 rwxp /usr/lib/libcom-core.so.0.0.1
b4b3b000 b60ba000 r-xp /usr/lib/libicudata.so.51.1
b60c1000 b60c2000 rwxp /usr/lib/libicudata.so.51.1
b60c2000 b6156000 r-xp /usr/lib/libstdc++.so.6.0.16
b615e000 b6161000 r-xp /usr/lib/libstdc++.so.6.0.16
b6161000 b6163000 rwxp /usr/lib/libstdc++.so.6.0.16
b6169000 b61de000 r-xp /usr/lib/libsqlite3.so.0.8.6
b61e5000 b61e8000 rwxp /usr/lib/libsqlite3.so.0.8.6
b61e8000 b61fe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6205000 b6206000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6207000 b620c000 r-xp /usr/lib/libffi.so.5.0.10
b6213000 b6214000 rwxp /usr/lib/libffi.so.5.0.10
b6214000 b621a000 r-xp /lib/librt-2.13.so
b6221000 b6222000 r-xp /lib/librt-2.13.so
b6222000 b6223000 rwxp /lib/librt-2.13.so
b6223000 b6224000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b622b000 b622c000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b622c000 b6232000 r-xp /usr/lib/libappsvc.so.0.1.0
b6239000 b623a000 rwxp /usr/lib/libappsvc.so.0.1.0
b623a000 b6267000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b626e000 b626f000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b6270000 b6343000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b634a000 b634e000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b634e000 b6351000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6358000 b6359000 rwxp /usr/lib/libproc-stat.so.0.2.86
b6359000 b6395000 r-xp /usr/lib/libsystemd.so.0.4.0
b639c000 b639d000 r-xp /usr/lib/libsystemd.so.0.4.0
b639d000 b639e000 rwxp /usr/lib/libsystemd.so.0.4.0
b639e000 b63a3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b63aa000 b63ab000 rwxp /usr/lib/libxdgmime.so.1.1.0
b63ab000 b63ae000 r-xp /usr/lib/libbundle.so.0.1.22
b63b5000 b63b6000 rwxp /usr/lib/libbundle.so.0.1.22
b63b7000 b640d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6415000 b641a000 rwxp /usr/lib/libpixman-1.so.0.28.2
b641a000 b6470000 r-xp /usr/lib/libfreetype.so.6.11.3
b6478000 b647c000 rwxp /usr/lib/libfreetype.so.6.11.3
b647c000 b64a4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b64a4000 b64a5000 rwxp /usr/lib/libfontconfig.so.1.8.0
b64a5000 b64e2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b64e9000 b64ea000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b64eb000 b64fe000 r-xp /usr/lib/libfribidi.so.0.3.1
b6505000 b6506000 rwxp /usr/lib/libfribidi.so.0.3.1
b6507000 b6521000 r-xp /usr/lib/libecore_con.so.1.7.99
b6528000 b6529000 rwxp /usr/lib/libecore_con.so.1.7.99
b652a000 b6533000 r-xp /usr/lib/libedbus.so.1.7.99
b653a000 b653b000 rwxp /usr/lib/libedbus.so.1.7.99
b653b000 b658b000 r-xp /usr/lib/libecore_x.so.1.7.99
b658b000 b658d000 rwxp /usr/lib/libecore_x.so.1.7.99
b658d000 b65ea000 r-xp /usr/lib/libedje.so.1.7.99
b65f2000 b65f4000 rwxp /usr/lib/libedje.so.1.7.99
b65f4000 b6605000 r-xp /usr/lib/libecore_input.so.1.7.99
b660c000 b660d000 rwxp /usr/lib/libecore_input.so.1.7.99
b660d000 b6612000 r-xp /usr/lib/libecore_file.so.1.7.99
b6619000 b661a000 rwxp /usr/lib/libecore_file.so.1.7.99
b661b000 b663d000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6644000 b6646000 rwxp /usr/lib/libecore_evas.so.1.7.99
b6646000 b665f000 r-xp /usr/lib/libeet.so.1.7.99
b6667000 b6668000 rwxp /usr/lib/libeet.so.1.7.99
b6670000 b66d9000 r-xp /lib/libm-2.13.so
b66e0000 b66e1000 r-xp /lib/libm-2.13.so
b66e1000 b66e2000 rwxp /lib/libm-2.13.so
b66e2000 b66e8000 r-xp /usr/lib/libwidget.so.1.0.0
b66f0000 b66f1000 rwxp /usr/lib/libwidget.so.1.0.0
b66f1000 b66f7000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b66fe000 b66ff000 rwxp /usr/lib/libwidget_provider_app.so.1.0.0
b66ff000 b6729000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6731000 b6732000 rwxp /usr/lib/libdbus-1.so.3.8.12
b6732000 b6802000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6802000 b6803000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6803000 b6807000 r-xp /usr/lib/libvconf.so.0.2.45
b680e000 b680f000 rwxp /usr/lib/libvconf.so.0.2.45
b680f000 b68f3000 r-xp /usr/lib/libicuuc.so.51.1
b68fa000 b6904000 rwxp /usr/lib/libicuuc.so.51.1
b6908000 b6a45000 r-xp /usr/lib/libicui18n.so.51.1
b6a4d000 b6a55000 rwxp /usr/lib/libicui18n.so.51.1
b6a55000 b6a96000 r-xp /usr/lib/libeina.so.1.7.99
b6a9d000 b6a9f000 rwxp /usr/lib/libeina.so.1.7.99
b6a9f000 b6ab6000 r-xp /usr/lib/libecore.so.1.7.99
b6abe000 b6abf000 rwxp /usr/lib/libecore.so.1.7.99
b6acd000 b6aef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6af6000 b6af7000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6af7000 b6afb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6b03000 b6b04000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6b04000 b6b18000 r-xp /lib/libpthread-2.13.so
b6b1f000 b6b20000 r-xp /lib/libpthread-2.13.so
b6b20000 b6b21000 rwxp /lib/libpthread-2.13.so
b6b23000 b6b57000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6b5e000 b6b60000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6b60000 b6b6d000 r-xp /usr/lib/libalarm.so.0.0.0
b6b74000 b6b76000 rwxp /usr/lib/libalarm.so.0.0.0
b6b76000 b6b8d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b94000 b6b95000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b95000 b6ba1000 r-xp /usr/lib/libaul.so.0.1.0
b6ba9000 b6baa000 rwxp /usr/lib/libaul.so.0.1.0
b6bab000 b6bb3000 r-xp /lib/libgcc_s-4.6.so.1
b6bb3000 b6bb4000 rwxp /lib/libgcc_s-4.6.so.1
b6bb4000 b6bb6000 r-xp /lib/libdl-2.13.so
b6bbd000 b6bbe000 r-xp /lib/libdl-2.13.so
b6bbe000 b6bbf000 rwxp /lib/libdl-2.13.so
b6bbf000 b6bca000 r-xp /lib/libunwind.so.8.0.1
b6bd1000 b6bd2000 rwxp /lib/libunwind.so.8.0.1
b6bf7000 b6d12000 r-xp /lib/libc-2.13.so
b6d1a000 b6d1c000 r-xp /lib/libc-2.13.so
b6d1c000 b6d1d000 rwxp /lib/libc-2.13.so
b6d20000 b6dee000 r-xp /usr/lib/libevas.so.1.7.99
b6df6000 b6e00000 rwxp /usr/lib/libevas.so.1.7.99
b6e13000 b6f4e000 r-xp /usr/lib/libelementary.so.1.7.99
b6f55000 b6f5d000 rwxp /usr/lib/libelementary.so.1.7.99
b6f64000 b6f66000 r-xp /usr/lib/libdlog.so.0.0.0
b6f6d000 b6f6e000 rwxp /usr/lib/libdlog.so.0.0.0
b6f6e000 b6f70000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f78000 b6f79000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f79000 b6f80000 r-xp /usr/lib/libappcore-watch.so.1.1
b6f88000 b6f89000 rwxp /usr/lib/libappcore-watch.so.1.1
b6f89000 b6f8c000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b6f8c000 b6f8e000 r-xp /usr/share/locale/en/LC_MESSAGES/elementary.mo
b6f8e000 b6f90000 r-xp /usr/share/locale/en_US/LC_MESSAGES/elementary.mo
b6f91000 b6f96000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6f9d000 b6f9e000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6f9e000 b6f9f000 r-xp /usr/share/locale/locale-archive
b6f9f000 b6fa3000 r-xp /usr/lib/libsys-assert.so
b6fab000 b6fac000 rwxp /usr/lib/libsys-assert.so
b6fac000 b6fc9000 r-xp /lib/ld-2.13.so
b6fd0000 b6fd1000 r-xp /lib/ld-2.13.so
b6fd1000 b6fd2000 rwxp /lib/ld-2.13.so
b6fd2000 b6fd4000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b6fdb000 b6fdc000 rwxp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b71c1000 b730b000 rwxp [heap]
bee0d000 bee2e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3369)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6c6e6dc) [/lib/libc.so.6] + 0x776dc
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
b_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:28.449-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:28.449-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:17:28.449-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:17:28.469-0500 E/RESOURCED(  935): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.solemntree.romannumeralwatch, table num : 1
09-09 12:17:28.469-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:17:28.469-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:17:28.469-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
09-09 12:17:28.469-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:17:28.469-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2097) > Launch with legacy way : no launchpad
09-09 12:17:28.469-0500 W/AUL_AMD (  934): amd_launch.c: start_process(580) > child process: 3409
09-09 12:17:28.559-0500 I/CAPI_WATCH_APPLICATION( 3409): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:17:28.579-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:28.579-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:28.599-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:28.599-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:28.609-0500 W/AUL_AMD (  934): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3409
09-09 12:17:28.609-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3341
09-09 12:17:28.609-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:17:28.639-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:28.639-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:28.639-0500 E/EFL     ( 3409): elementary<3409> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
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
09-09 12:17:31.529-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103369726f6d147344144
