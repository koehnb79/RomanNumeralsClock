S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3341
Date: 2016-09-09 12:17:25-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbecede64, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbeced930, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb42384d0
r10  = 0x0000000c, fp   = 0xbeced924
ip   = 0x0000000c, sp   = 0xbeced3b0
lr   = 0xb6b6af5c, pc   = 0xb6ba56dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:     17876 KB
Buffers:     10312 KB
Cached:      96928 KB
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
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3341 TID = 3341
3341 3353 

Maps Information
b351e000 b35aa000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b35aa000 b35b9000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b35b9000 b35d0000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b35d8000 b35dd000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b35dd000 b377c000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b377c000 b3803000 rwxs anon_inode:dmabuf
b3803000 b380e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3816000 b3817000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3817000 b3819000 r-xp /usr/lib/libgenlock.so
b3820000 b3821000 rwxp /usr/lib/libgenlock.so
b3821000 b3825000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b3825000 b382c000 r-xs /usr/lib/gconv/gconv-modules.cache
b382c000 b382f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3836000 b3837000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3838000 b4037000 rwxp [stack:3353]
b4037000 b4237000 r-xp /usr/share/locale/locale-archive
b423c000 b423f000 r-xp /lib/libattr.so.1.1.0
b4246000 b4247000 rwxp /lib/libattr.so.1.1.0
b4247000 b4249000 r-xp /usr/lib/libXau.so.6.0.0
b4250000 b4251000 rwxp /usr/lib/libXau.so.6.0.0
b4252000 b4254000 r-xp /usr/lib/libiniparser.so.0
b425c000 b425d000 rwxp /usr/lib/libiniparser.so.0
b425d000 b4264000 r-xp /lib/libcrypt-2.13.so
b426b000 b426c000 r-xp /lib/libcrypt-2.13.so
b426c000 b426d000 rwxp /lib/libcrypt-2.13.so
b4294000 b4297000 r-xp /lib/libcap.so.2.21
b429e000 b429f000 rwxp /lib/libcap.so.2.21
b429f000 b42a1000 r-xp /usr/lib/libiri.so
b42a8000 b42a9000 rwxp /usr/lib/libiri.so
b42a9000 b42b4000 r-xp /usr/lib/libgpg-error.so.0.15.0
b42bb000 b42bc000 rwxp /usr/lib/libgpg-error.so.0.15.0
b42bd000 b4465000 r-xp /usr/lib/libcrypto.so.1.0.0
b4465000 b447a000 rwxp /usr/lib/libcrypto.so.1.0.0
b447e000 b44cb000 r-xp /usr/lib/libssl.so.1.0.0
b44d2000 b44d7000 rwxp /usr/lib/libssl.so.1.0.0
b44d7000 b4505000 r-xp /usr/lib/libidn.so.11.5.44
b450c000 b450d000 rwxp /usr/lib/libidn.so.11.5.44
b450d000 b4516000 r-xp /usr/lib/libcares.so.2.1.0
b451e000 b451f000 rwxp /usr/lib/libcares.so.2.1.0
b4520000 b4533000 r-xp /usr/lib/libxcb.so.1.1.0
b453b000 b453c000 rwxp /usr/lib/libxcb.so.1.1.0
b453c000 b4543000 r-xp /usr/lib/libtbm.so.1.0.0
b454a000 b454b000 rwxp /usr/lib/libtbm.so.1.0.0
b454b000 b454d000 r-xp /usr/lib/libdri2.so.0.0.0
b4554000 b4555000 rwxp /usr/lib/libdri2.so.0.0.0
b4555000 b455a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4561000 b4562000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b4562000 b456a000 r-xp /usr/lib/libdrm.so.2.4.0
b4571000 b4572000 rwxp /usr/lib/libdrm.so.2.4.0
b4573000 b4575000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b457c000 b457d000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b457d000 b457f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4587000 b4588000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b4588000 b4654000 r-xp /usr/lib/libxml2.so.2.7.8
b465b000 b4660000 rwxp /usr/lib/libxml2.so.2.7.8
b4661000 b467e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4686000 b4687000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b4687000 b468a000 r-xp /usr/lib/libsmack.so.1.0.0
b4691000 b4692000 rwxp /usr/lib/libsmack.so.1.0.0
b4693000 b4695000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b469c000 b469d000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b469d000 b46ad000 r-xp /lib/libresolv-2.13.so
b46ad000 b46ae000 r-xp /lib/libresolv-2.13.so
b46ae000 b46af000 rwxp /lib/libresolv-2.13.so
b46b1000 b472d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b4734000 b4739000 rwxp /usr/lib/libgcrypt.so.20.0.3
b4739000 b4751000 r-xp /usr/lib/liblzma.so.5.0.3
b4758000 b4759000 rwxp /usr/lib/liblzma.so.5.0.3
b4759000 b4771000 r-xp /usr/lib/libpng12.so.0.50.0
b4778000 b4779000 rwxp /usr/lib/libpng12.so.0.50.0
b477a000 b4790000 r-xp /lib/libexpat.so.1.5.2
b4798000 b479a000 rwxp /lib/libexpat.so.1.5.2
b479a000 b47de000 r-xp /usr/lib/libcurl.so.4.3.0
b47e5000 b47e7000 rwxp /usr/lib/libcurl.so.4.3.0
b47e7000 b47f1000 r-xp /usr/lib/libXext.so.6.4.0
b47f9000 b47fa000 rwxp /usr/lib/libXext.so.6.4.0
b47fa000 b47fe000 r-xp /usr/lib/libXtst.so.6.1.0
b4805000 b4806000 rwxp /usr/lib/libXtst.so.6.1.0
b4806000 b480c000 r-xp /usr/lib/libXrender.so.1.3.0
b4813000 b4814000 rwxp /usr/lib/libXrender.so.1.3.0
b4815000 b481b000 r-xp /usr/lib/libXrandr.so.2.2.0
b4822000 b4823000 rwxp /usr/lib/libXrandr.so.2.2.0
b4823000 b4824000 r-xp /usr/lib/libXinerama.so.1.0.0
b482c000 b482d000 rwxp /usr/lib/libXinerama.so.1.0.0
b482d000 b4836000 r-xp /usr/lib/libXi.so.6.1.0
b483d000 b483e000 rwxp /usr/lib/libXi.so.6.1.0
b483e000 b4841000 r-xp /usr/lib/libXfixes.so.3.1.0
b4848000 b4849000 rwxp /usr/lib/libXfixes.so.3.1.0
b4849000 b484b000 r-xp /usr/lib/libXgesture.so.7.0.0
b4852000 b4853000 rwxp /usr/lib/libXgesture.so.7.0.0
b4853000 b4855000 r-xp /usr/lib/libXcomposite.so.1.0.0
b485c000 b485d000 rwxp /usr/lib/libXcomposite.so.1.0.0
b485e000 b4860000 r-xp /usr/lib/libXdamage.so.1.1.0
b4867000 b4868000 rwxp /usr/lib/libXdamage.so.1.1.0
b4868000 b486f000 r-xp /usr/lib/libXcursor.so.1.0.2
b4876000 b4877000 rwxp /usr/lib/libXcursor.so.1.0.2
b4877000 b4878000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b487f000 b4880000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b4880000 b4886000 r-xp /usr/lib/libecore_imf.so.1.7.99
b488d000 b488e000 rwxp /usr/lib/libecore_imf.so.1.7.99
b488e000 b48a5000 r-xp /usr/lib/liblua-5.1.so
b48ad000 b48ae000 rwxp /usr/lib/liblua-5.1.so
b48af000 b48b6000 r-xp /usr/lib/libembryo.so.1.7.99
b48bd000 b48be000 rwxp /usr/lib/libembryo.so.1.7.99
b48be000 b48c1000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b48c8000 b48c9000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b48c9000 b48cd000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b48d5000 b48d6000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b48d6000 b48db000 r-xp /usr/lib/libecore_fb.so.1.7.99
b48e2000 b48e4000 rwxp /usr/lib/libecore_fb.so.1.7.99
b48e4000 b4907000 r-xp /usr/lib/libjpeg.so.8.0.2
b490e000 b490f000 rwxp /usr/lib/libjpeg.so.8.0.2
b4920000 b4936000 r-xp /lib/libz.so.1.2.5
b493d000 b493e000 rwxp /lib/libz.so.1.2.5
b493e000 b4a1f000 r-xp /usr/lib/libX11.so.6.3.0
b4a26000 b4a2a000 rwxp /usr/lib/libX11.so.6.3.0
b4a2a000 b4a33000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4a3b000 b4a3c000 rwxp /usr/lib/libwidget_provider.so.1.0.0
b4a3c000 b4a42000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b4a4a000 b4a4b000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b4a4b000 b4a57000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4a5e000 b4a5f000 rwxp /usr/lib/libwidget_service.so.1.0.0
b4a60000 b4a69000 r-xp /usr/lib/libcom-core.so.0.0.1
b4a71000 b4a72000 rwxp /usr/lib/libcom-core.so.0.0.1
b4a72000 b5ff1000 r-xp /usr/lib/libicudata.so.51.1
b5ff8000 b5ff9000 rwxp /usr/lib/libicudata.so.51.1
b5ff9000 b608d000 r-xp /usr/lib/libstdc++.so.6.0.16
b6095000 b6098000 r-xp /usr/lib/libstdc++.so.6.0.16
b6098000 b609a000 rwxp /usr/lib/libstdc++.so.6.0.16
b60a0000 b6115000 r-xp /usr/lib/libsqlite3.so.0.8.6
b611c000 b611f000 rwxp /usr/lib/libsqlite3.so.0.8.6
b611f000 b6135000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b613c000 b613d000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b613e000 b6143000 r-xp /usr/lib/libffi.so.5.0.10
b614a000 b614b000 rwxp /usr/lib/libffi.so.5.0.10
b614b000 b6151000 r-xp /lib/librt-2.13.so
b6158000 b6159000 r-xp /lib/librt-2.13.so
b6159000 b615a000 rwxp /lib/librt-2.13.so
b615a000 b615b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6162000 b6163000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6163000 b6169000 r-xp /usr/lib/libappsvc.so.0.1.0
b6170000 b6171000 rwxp /usr/lib/libappsvc.so.0.1.0
b6171000 b619e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b61a5000 b61a6000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b61a7000 b627a000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6281000 b6285000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6285000 b6288000 r-xp /usr/lib/libproc-stat.so.0.2.86
b628f000 b6290000 rwxp /usr/lib/libproc-stat.so.0.2.86
b6290000 b62cc000 r-xp /usr/lib/libsystemd.so.0.4.0
b62d3000 b62d4000 r-xp /usr/lib/libsystemd.so.0.4.0
b62d4000 b62d5000 rwxp /usr/lib/libsystemd.so.0.4.0
b62d5000 b62da000 r-xp /usr/lib/libxdgmime.so.1.1.0
b62e1000 b62e2000 rwxp /usr/lib/libxdgmime.so.1.1.0
b62e2000 b62e5000 r-xp /usr/lib/libbundle.so.0.1.22
b62ec000 b62ed000 rwxp /usr/lib/libbundle.so.0.1.22
b62ee000 b6344000 r-xp /usr/lib/libpixman-1.so.0.28.2
b634c000 b6351000 rwxp /usr/lib/libpixman-1.so.0.28.2
b6351000 b63a7000 r-xp /usr/lib/libfreetype.so.6.11.3
b63af000 b63b3000 rwxp /usr/lib/libfreetype.so.6.11.3
b63b3000 b63db000 r-xp /usr/lib/libfontconfig.so.1.8.0
b63db000 b63dc000 rwxp /usr/lib/libfontconfig.so.1.8.0
b63dc000 b6419000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6420000 b6421000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b6422000 b6435000 r-xp /usr/lib/libfribidi.so.0.3.1
b643c000 b643d000 rwxp /usr/lib/libfribidi.so.0.3.1
b643e000 b6458000 r-xp /usr/lib/libecore_con.so.1.7.99
b645f000 b6460000 rwxp /usr/lib/libecore_con.so.1.7.99
b6461000 b646a000 r-xp /usr/lib/libedbus.so.1.7.99
b6471000 b6472000 rwxp /usr/lib/libedbus.so.1.7.99
b6472000 b64c2000 r-xp /usr/lib/libecore_x.so.1.7.99
b64c2000 b64c4000 rwxp /usr/lib/libecore_x.so.1.7.99
b64c4000 b6521000 r-xp /usr/lib/libedje.so.1.7.99
b6529000 b652b000 rwxp /usr/lib/libedje.so.1.7.99
b652b000 b653c000 r-xp /usr/lib/libecore_input.so.1.7.99
b6543000 b6544000 rwxp /usr/lib/libecore_input.so.1.7.99
b6544000 b6549000 r-xp /usr/lib/libecore_file.so.1.7.99
b6550000 b6551000 rwxp /usr/lib/libecore_file.so.1.7.99
b6552000 b6574000 r-xp /usr/lib/libecore_evas.so.1.7.99
b657b000 b657d000 rwxp /usr/lib/libecore_evas.so.1.7.99
b657d000 b6596000 r-xp /usr/lib/libeet.so.1.7.99
b659e000 b659f000 rwxp /usr/lib/libeet.so.1.7.99
b65a7000 b6610000 r-xp /lib/libm-2.13.so
b6617000 b6618000 r-xp /lib/libm-2.13.so
b6618000 b6619000 rwxp /lib/libm-2.13.so
b6619000 b661f000 r-xp /usr/lib/libwidget.so.1.0.0
b6627000 b6628000 rwxp /usr/lib/libwidget.so.1.0.0
b6628000 b662e000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b6635000 b6636000 rwxp /usr/lib/libwidget_provider_app.so.1.0.0
b6636000 b6660000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6668000 b6669000 rwxp /usr/lib/libdbus-1.so.3.8.12
b6669000 b6739000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6739000 b673a000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b673a000 b673e000 r-xp /usr/lib/libvconf.so.0.2.45
b6745000 b6746000 rwxp /usr/lib/libvconf.so.0.2.45
b6746000 b682a000 r-xp /usr/lib/libicuuc.so.51.1
b6831000 b683b000 rwxp /usr/lib/libicuuc.so.51.1
b683f000 b697c000 r-xp /usr/lib/libicui18n.so.51.1
b6984000 b698c000 rwxp /usr/lib/libicui18n.so.51.1
b698c000 b69cd000 r-xp /usr/lib/libeina.so.1.7.99
b69d4000 b69d6000 rwxp /usr/lib/libeina.so.1.7.99
b69d6000 b69ed000 r-xp /usr/lib/libecore.so.1.7.99
b69f5000 b69f6000 rwxp /usr/lib/libecore.so.1.7.99
b6a04000 b6a26000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a2d000 b6a2e000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a2e000 b6a32000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6a3a000 b6a3b000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6a3b000 b6a4f000 r-xp /lib/libpthread-2.13.so
b6a56000 b6a57000 r-xp /lib/libpthread-2.13.so
b6a57000 b6a58000 rwxp /lib/libpthread-2.13.so
b6a5a000 b6a8e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a95000 b6a97000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6a97000 b6aa4000 r-xp /usr/lib/libalarm.so.0.0.0
b6aab000 b6aad000 rwxp /usr/lib/libalarm.so.0.0.0
b6aad000 b6ac4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6acb000 b6acc000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6acc000 b6ad8000 r-xp /usr/lib/libaul.so.0.1.0
b6ae0000 b6ae1000 rwxp /usr/lib/libaul.so.0.1.0
b6ae2000 b6aea000 r-xp /lib/libgcc_s-4.6.so.1
b6aea000 b6aeb000 rwxp /lib/libgcc_s-4.6.so.1
b6aeb000 b6aed000 r-xp /lib/libdl-2.13.so
b6af4000 b6af5000 r-xp /lib/libdl-2.13.so
b6af5000 b6af6000 rwxp /lib/libdl-2.13.so
b6af6000 b6b01000 r-xp /lib/libunwind.so.8.0.1
b6b08000 b6b09000 rwxp /lib/libunwind.so.8.0.1
b6b2e000 b6c49000 r-xp /lib/libc-2.13.so
b6c51000 b6c53000 r-xp /lib/libc-2.13.so
b6c53000 b6c54000 rwxp /lib/libc-2.13.so
b6c57000 b6d25000 r-xp /usr/lib/libevas.so.1.7.99
b6d2d000 b6d37000 rwxp /usr/lib/libevas.so.1.7.99
b6d4a000 b6e85000 r-xp /usr/lib/libelementary.so.1.7.99
b6e8c000 b6e94000 rwxp /usr/lib/libelementary.so.1.7.99
b6e9b000 b6e9d000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea4000 b6ea5000 rwxp /usr/lib/libdlog.so.0.0.0
b6ea5000 b6ea7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6eaf000 b6eb0000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6eb0000 b6eb7000 r-xp /usr/lib/libappcore-watch.so.1.1
b6ebf000 b6ec0000 rwxp /usr/lib/libappcore-watch.so.1.1
b6ec0000 b6ec3000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b6ec3000 b6ec5000 r-xp /usr/share/locale/en/LC_MESSAGES/elementary.mo
b6ec5000 b6ec7000 r-xp /usr/share/locale/en_US/LC_MESSAGES/elementary.mo
b6ec8000 b6ecd000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6ed4000 b6ed5000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b6ed5000 b6ed6000 r-xp /usr/share/locale/locale-archive
b6ed6000 b6eda000 r-xp /usr/lib/libsys-assert.so
b6ee2000 b6ee3000 rwxp /usr/lib/libsys-assert.so
b6ee3000 b6f00000 r-xp /lib/ld-2.13.so
b6f07000 b6f08000 r-xp /lib/ld-2.13.so
b6f08000 b6f09000 rwxp /lib/ld-2.13.so
b6f09000 b6f0b000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b6f12000 b6f13000 rwxp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b8707000 b8851000 rwxp [heap]
becce000 becef000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3341)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6ba56dc) [/lib/libc.so.6] + 0x776dc
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
kground tick update
09-09 12:17:08.599-0500 I/WATCH_CORE( 3061): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
09-09 12:17:08.639-0500 W/W_HOME  ( 1143): gesture.c: _widget_updated_cb(190) > widget updated
09-09 12:17:08.639-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_disable_timer_del(151) > timer del
09-09 12:17:08.639-0500 W/W_HOME  ( 1143): gesture.c: _manual_render(176) > 
09-09 12:17:08.649-0500 W/W_HOME  ( 1143): gesture.c: _manual_render(176) > 
09-09 12:17:08.669-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_enable(133) > 0
09-09 12:17:09.369-0500 W/AUL_AMD (  934): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:17:09.369-0500 W/AUL_AMD (  934): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
09-09 12:17:09.389-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:09.399-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3061
09-09 12:17:09.399-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:17:09.489-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:09.489-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:09.509-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:09.509-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:09.549-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:09.549-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:09.559-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:09.559-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:09.559-0500 E/EFL     ( 3237): elementary<3237> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:09.579-0500 E/EFL     ( 3237): elementary<3237> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:09.579-0500 E/EFL     ( 3237): elementary<3237> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:09.579-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:09.599-0500 E/EFL     ( 3237): elementary<3237> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:09.609-0500 E/EFL     ( 3237): elementary<3237> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:09.609-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:09.609-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:09.609-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:09.609-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:09.609-0500 E/EFL     ( 3237): elementary<3237> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:09.609-0500 I/AUL_PAD ( 3237): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:17:18.979-0500 E/PKGMGR  ( 3308): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
09-09 12:17:19.129-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: main(2131) > package manager server start
09-09 12:17:19.209-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: req_cb(650) > req_id=[org.solemntree.romannumeralwatch_1368511052], req_type=[1], pkg_type=[rpm], pkgid=[org.solemntree.romannumeralwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.solemntree.romannumeralwatch_1368511052' '-r' 'org.solemntree.romannumeralwatch'], cookie=[E+TU8Qp6QvJ8E3Xxe9IH4gvtTiw=], backend_flag=[0]
09-09 12:17:19.209-0500 E/PKGMGR  ( 3310): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.solemntree.romannumeralwatch]
09-09 12:17:19.209-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.solemntree.romannumeralwatch 
09-09 12:17:19.219-0500 E/PKGMGR  ( 3308): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[33080002]
09-09 12:17:19.219-0500 E/PKGMGR_SERVER( 3316): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.solemntree.romannumeralwatch]
09-09 12:17:19.369-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
09-09 12:17:19.379-0500 W/AUL_AMD (  934): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
09-09 12:17:19.389-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
09-09 12:17:19.389-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.solemntree.romannumeralwatch is being updateded:0
09-09 12:17:19.579-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
09-09 12:17:19.589-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
09-09 12:17:19.599-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
09-09 12:17:19.599-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
09-09 12:17:19.599-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 1
09-09 12:17:19.599-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 1
09-09 12:17:19.599-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 20 1
09-09 12:17:19.599-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 1
09-09 12:17:19.619-0500 E/PKGMGR_CERT( 3316): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
09-09 12:17:19.789-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3237
09-09 12:17:19.879-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2957
09-09 12:17:19.929-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:19.929-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:19.949-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:19.949-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:19.979-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:19.989-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:19.989-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:19.989-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:19.989-0500 E/EFL     ( 3317): elementary<3317> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:20.009-0500 E/EFL     ( 3317): elementary<3317> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:20.019-0500 E/EFL     ( 3317): elementary<3317> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:20.019-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:20.039-0500 E/EFL     ( 3317): elementary<3317> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:20.049-0500 E/EFL     ( 3317): elementary<3317> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:20.049-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:20.049-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:20.049-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:20.049-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:20.049-0500 E/EFL     ( 3317): elementary<3317> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:20.049-0500 I/AUL_PAD ( 3317): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:17:20.219-0500 I/efl-extension( 3318): efl_extension.c: eext_mod_init(40) > Init
09-09 12:17:20.239-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:20.239-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:20.259-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:20.259-0500 I/UXT     ( 3318): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
09-09 12:17:20.259-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:20.299-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:20.309-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3317
09-09 12:17:20.319-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:20.319-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:20.319-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:20.319-0500 E/EFL     ( 3318): elementary<3318> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:20.339-0500 E/EFL     ( 3318): elementary<3318> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:20.339-0500 E/EFL     ( 3318): elementary<3318> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:20.339-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:20.359-0500 E/EFL     ( 3318): elementary<3318> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:20.369-0500 E/EFL     ( 3318): elementary<3318> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:20.369-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:20.369-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:20.369-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:20.369-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:20.369-0500 E/EFL     ( 3318): elementary<3318> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:20.369-0500 I/AUL_PAD ( 3318): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:17:20.439-0500 I/Adreno-EGL( 3318): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
09-09 12:17:20.439-0500 I/Adreno-EGL( 3318): OpenGL ES Shader Compiler Version: E031.24.00.16
09-09 12:17:20.439-0500 I/Adreno-EGL( 3318): Build Date: 09/02/15 Wed
09-09 12:17:20.439-0500 I/Adreno-EGL( 3318): Local Branch: 
09-09 12:17:20.439-0500 I/Adreno-EGL( 3318): Remote Branch: 
09-09 12:17:20.439-0500 I/Adreno-EGL( 3318): Local Patches: 
09-09 12:17:20.439-0500 I/Adreno-EGL( 3318): Reconstruct Branch: 
09-09 12:17:21.379-0500 E/rpm-installer( 3316): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
09-09 12:17:21.519-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:17:21.929-0500 W/WATCH_CORE( 3061): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
09-09 12:17:21.929-0500 I/WATCH_CORE( 3061): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
09-09 12:17:21.939-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: OnReceiveDisplayChanged(963) > [0;32mINFO: LCDOff receive data : -1226499316[0;m
09-09 12:17:21.939-0500 W/W_HOME  ( 1143): dbus.c: _dbus_message_recv_cb(204) > LCD off
09-09 12:17:21.939-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_disable_timer_del(151) > timer del
09-09 12:17:21.939-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_enable(133) > 1
09-09 12:17:21.939-0500 W/W_HOME  ( 1143): event_manager.c: _lcd_off_cb(699) > lcd state: 0
09-09 12:17:21.939-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:21.939-0500 W/STARTER ( 1092): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
09-09 12:17:21.939-0500 W/STARTER ( 1092): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
09-09 12:17:21.939-0500 E/STARTER ( 1092): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
09-09 12:17:21.939-0500 W/STARTER ( 1092): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
09-09 12:17:21.939-0500 W/STARTER ( 1092): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
09-09 12:17:21.939-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: OnReceiveDisplayChanged(964) > [0;32mINFO: WakeupServiceStop[0;m
09-09 12:17:21.939-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: WakeupServiceStop(401) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
09-09 12:17:21.939-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
09-09 12:17:21.949-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
09-09 12:17:21.949-0500 W/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-09 12:17:21.949-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 0[0;m
09-09 12:17:21.949-0500 I/HIGEAR  ( 1604): WakeupService.cpp: WakeupServiceStop(405) > [svoice:Application:WakeupServiceStop:IN]
09-09 12:17:22.279-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1261]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
09-09 12:17:22.279-0500 W/STARTER ( 1092): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
09-09 12:17:22.279-0500 W/STARTER ( 1092): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
09-09 12:17:22.279-0500 W/STARTER ( 1092): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
09-09 12:17:22.279-0500 W/STARTER ( 1092): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
09-09 12:17:22.289-0500 I/APP_CORE( 1143): appcore-efl.c: __do_app(429) > [APP 1143] Event: PAUSE State: RUNNING
09-09 12:17:22.289-0500 I/CAPI_APPFW_APPLICATION( 1143): app_main.c: app_appcore_pause(202) > app_appcore_pause
09-09 12:17:22.289-0500 W/W_HOME  ( 1143): main.c: _appcore_pause_cb(692) > appcore pause
09-09 12:17:22.289-0500 W/W_HOME  ( 1143): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
09-09 12:17:22.289-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:22.289-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:22.289-0500 W/W_HOME  ( 1143): main.c: home_pause(762) > clock/widget paused
09-09 12:17:22.289-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:22.289-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:22.289-0500 E/CAPI_APPFW_APP_CONTROL( 1261): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
09-09 12:17:22.289-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1261]   [com.samsung.w-home]register msg port [false][0m
09-09 12:17:22.289-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
09-09 12:17:22.359-0500 I/SHealth_Common( 1536): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
09-09 12:17:22.359-0500 I/SHealth_Service( 1536): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
09-09 12:17:22.789-0500 I/APP_CORE( 1143): appcore-efl.c: __do_app(429) > [APP 1143] Event: MEM_FLUSH State: PAUSED
09-09 12:17:23.519-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): dbus.c: _dbus_message_recv_cb(186) > LCD on
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_disable_timer_set(161) > timer set
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_disable_timer_del(151) > timer del
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): gesture.c: _apps_status_get(123) > apps status:0
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:2117
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_schedule(211) > schedule, manual render
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): event_manager.c: _lcd_on_cb(691) > lcd state: 1
09-09 12:17:24.049-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:24.059-0500 W/STARTER ( 1092): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [powerkey] after screen off time [2117]ms
09-09 12:17:24.059-0500 W/STARTER ( 1092): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
09-09 12:17:24.069-0500 I/APP_CORE( 1143): appcore-efl.c: __do_app(429) > [APP 1143] Event: RESUME State: PAUSED
09-09 12:17:24.069-0500 I/CAPI_APPFW_APPLICATION( 1143): app_main.c: app_appcore_resume(223) > app_appcore_resume
09-09 12:17:24.069-0500 W/W_HOME  ( 1143): main.c: _appcore_resume_cb(683) > appcore resume
09-09 12:17:24.069-0500 W/W_HOME  ( 1143): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
09-09 12:17:24.069-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:24.069-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:24.069-0500 W/W_HOME  ( 1143): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
09-09 12:17:24.069-0500 W/W_HOME  ( 1143): main.c: home_resume(735) > clock/widget resumed
09-09 12:17:24.069-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:24.069-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
09-09 12:17:24.069-0500 W/WATCH_CORE( 3061): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
09-09 12:17:24.069-0500 I/WATCH_CORE( 3061): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
09-09 12:17:24.099-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: OnReceiveDisplayChanged(954) > [0;32mINFO: LCDOn receive data : -1226499316[0;m
09-09 12:17:24.099-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: OnReceiveDisplayChanged(955) > [0;32mINFO: WakeupServiceStart[0;m
09-09 12:17:24.099-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: WakeupServiceStart(371) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
09-09 12:17:24.099-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
09-09 12:17:24.099-0500 W/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
09-09 12:17:24.099-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: WakeupServiceStart(390) > [0;32mINFO: 500[0;m
09-09 12:17:24.099-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
09-09 12:17:24.099-0500 W/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
09-09 12:17:24.109-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
09-09 12:17:24.109-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
09-09 12:17:24.109-0500 W/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-09 12:17:24.109-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 1[0;m
09-09 12:17:24.109-0500 I/HIGEAR  ( 1604): WakeupService.cpp: WakeupServiceStart(395) > [svoice:Application:WakeupServiceStart:IN]
09-09 12:17:24.139-0500 E/SHealth_Common( 1536): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
09-09 12:17:24.199-0500 I/SHealth_Common( 1536): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
09-09 12:17:24.199-0500 I/SHealth_Service( 1536): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
09-09 12:17:24.209-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1261]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
09-09 12:17:24.229-0500 W/STARTER ( 1092): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [powerkey]
09-09 12:17:24.229-0500 W/STARTER ( 1092): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
09-09 12:17:24.259-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
09-09 12:17:24.259-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_enable(133) > 0
09-09 12:17:24.479-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: sighandler(409) > child NORMAL exit [3316]
09-09 12:17:24.499-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
09-09 12:17:24.529-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.solemntree.romannumeralwatch is updated, need to check validation
09-09 12:17:24.529-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.solemntree.romannumeralwatch
09-09 12:17:24.539-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, COMPLETED]
09-09 12:17:24.539-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6915) > package install complete
09-09 12:17:24.539-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_package_install_event(4787) > 
09-09 12:17:24.539-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
09-09 12:17:24.629-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(249) > clock org.solemntree.romannumeralwatch is updated, preload:0 update:0 event->update:0
09-09 12:17:24.669-0500 E/PKGMGR_INFO(  898): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-09 12:17:24.669-0500 E/STARTER ( 1092): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
09-09 12:17:24.679-0500 E/APPS    ( 1143): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
09-09 12:17:24.879-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 4
09-09 12:17:24.879-0500 E/AUL_AMD (  934): amd_request.c: __app_process_by_pid(193) > pid(3061) is dead. cmd(4) is canceled
09-09 12:17:24.879-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
09-09 12:17:24.889-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103061726f6d1473441444
09-09 12:17:24.889-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:24.899-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:24.899-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:17:24.899-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:17:24.929-0500 E/RESOURCED(  935): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.solemntree.romannumeralwatch, table num : 1
09-09 12:17:24.929-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:17:24.949-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:17:24.949-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
09-09 12:17:24.949-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:17:24.949-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2097) > Launch with legacy way : no launchpad
09-09 12:17:24.949-0500 W/AUL_AMD (  934): amd_launch.c: start_process(580) > child process: 3341
09-09 12:17:24.999-0500 W/AUL_AMD (  934): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3341
09-09 12:17:24.999-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3061
09-09 12:17:24.999-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:25.069-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.069-0500 E/CAPI_APPFW_APP_CONTROL( 1261): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
09-09 12:17:25.069-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1261]   [com.samsung.w-home]register msg port [true][0m
09-09 12:17:25.069-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:25.079-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1143
09-09 12:17:25.079-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1261]   [MUSIC_PLAYER_EVENT][0m
09-09 12:17:25.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:17:25.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:17:25.079-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: preference_get_int(1132) > preference_get_int(1261) : key(music-control-service_native/playing_diration) error
09-09 12:17:25.079-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1261]   preference_get_int() .. [0xfef00030][0m
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:25.079-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.079-0500 W/W_HOME  ( 1143): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:17:25.079-0500 E/W_HOME  ( 1143): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:17:25.089-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1261]   [MUSIC_PLAYER_EVENT][0m
09-09 12:17:25.089-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:17:25.089-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:17:25.089-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: preference_get_int(1132) > preference_get_int(1261) : key(music-control-service_native/playing_diration) error
09-09 12:17:25.089-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1261]   preference_get_int() .. [0xfef00030][0m
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:25.089-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.089-0500 W/W_HOME  ( 1143): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:17:25.089-0500 E/W_HOME  ( 1143): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:17:25.089-0500 I/CAPI_WATCH_APPLICATION( 3341): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:17:25.089-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:25.099-0500 I/TIZEN_N_SOUND_MANAGER( 1261): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
09-09 12:17:25.099-0500 W/TIZEN_N_SOUND_MANAGER( 1261): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:25.099-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:25.099-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3341
09-09 12:17:25.099-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:17:25.129-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:17:25.129-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:17:25.159-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:17:25.159-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:17:25.189-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:17:25.189-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:17:25.189-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:17:25.189-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:17:25.189-0500 E/EFL     ( 3341): elementary<3341> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:17:25.219-0500 E/EFL     ( 3341): elementary<3341> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:17:25.219-0500 E/EFL     ( 3341): elementary<3341> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:17:25.219-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:17:25.239-0500 E/EFL     ( 3341): elementary<3341> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:17:25.249-0500 E/EFL     ( 3341): elementary<3341> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:17:25.249-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:17:25.249-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:17:25.249-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:17:25.249-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:17:25.249-0500 E/EFL     ( 3341): elementary<3341> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:17:25.319-0500 W/WATCH_CORE( 3341): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:17:25.319-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1573.991821] pkgname: org.solemntree.romannumeralwatch, id: file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1573.991821.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://23068710:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:17:25.319-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[1573.991821] pkgname[org.solemntree.romannumeralwatch], id[file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1573.991821.png] content[] cluster[user,created] category[default] widget_fname[pixmap://23068710:4] gbar_fname[]
09-09 12:17:25.329-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
09-09 12:17:25.329-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
09-09 12:17:25.519-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
09-09 12:17:25.519-0500 E/PKGMGR_SERVER( 3310): pkgmgr-server.c: main(2185) > package manager server terminated.
09-09 12:17:25.539-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103341726f6d147344144
