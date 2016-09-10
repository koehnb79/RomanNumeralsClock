S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3454
Date: 2016-09-09 12:17:43-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbed8d07c, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbed8cb48, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb5af84d0
r10  = 0x0000000c, fp   = 0xbed8cb3c
ip   = 0x0000000c, sp   = 0xbed8c5c8
lr   = 0xb69cef5c, pc   = 0xb6a096dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:      6276 KB
Buffers:      9252 KB
Cached:      93280 KB
VmPeak:      63560 KB
VmSize:      63016 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13020 KB
VmRSS:       13020 KB
VmData:      11636 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3454 TID = 3454
3454 3595 

Maps Information
b346c000 b3483000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3490000 b3517000 rw-s anon_inode:dmabuf
b3517000 b3522000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b352b000 b352d000 r-xp /usr/lib/libgenlock.so
b3540000 b3543000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b354c000 b3d4b000 rwxp [stack:3595]
b3f4b000 b3f52000 r-xp /usr/lib/libtbm.so.1.0.0
b3f5a000 b3f5c000 r-xp /usr/lib/libdri2.so.0.0.0
b3f64000 b3f69000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f71000 b3f79000 r-xp /usr/lib/libdrm.so.2.4.0
b3f81000 b3f8a000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3f93000 b3f9f000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3fa7000 b3fb0000 r-xp /usr/lib/libcom-core.so.0.0.1
b5540000 b5546000 r-xp /usr/lib/libwidget.so.1.0.0
b554f000 b5555000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b555d000 b5641000 r-xp /usr/lib/libicuuc.so.51.1
b5656000 b5793000 r-xp /usr/lib/libicui18n.so.51.1
b57a3000 b57b0000 r-xp /usr/lib/libalarm.so.0.0.0
b57b9000 b57c0000 r-xp /usr/lib/libappcore-watch.so.1.1
b5968000 b5972000 r-xp /lib/libnss_files-2.13.so
b597b000 b5a4a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a60000 b5a84000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5a8d000 b5a93000 r-xp /usr/lib/libappsvc.so.0.1.0
b5a9b000 b5a9d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5aa6000 b5aaa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5abc000 b5ac1000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5ac9000 b5acb000 r-xp /usr/lib/libiniparser.so.0
b5ad4000 b5ad9000 r-xp /usr/lib/libappcore-common.so.1.1
b5ae1000 b5ae3000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b5aeb000 b5aef000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5afc000 b5afe000 r-xp /usr/lib/libXau.so.6.0.0
b5b07000 b5b0e000 r-xp /lib/libcrypt-2.13.so
b5b3e000 b5b40000 r-xp /usr/lib/libiri.so
b5b48000 b5cf0000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d09000 b5d56000 r-xp /usr/lib/libssl.so.1.0.0
b5d63000 b5d91000 r-xp /usr/lib/libidn.so.11.5.44
b5d99000 b5da2000 r-xp /usr/lib/libcares.so.2.1.0
b5dab000 b5dbe000 r-xp /usr/lib/libxcb.so.1.1.0
b5dc7000 b5dc9000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5dd2000 b5dd4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ddd000 b5ea9000 r-xp /usr/lib/libxml2.so.2.7.8
b5eb6000 b5eb8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5ec0000 b5ec5000 r-xp /usr/lib/libffi.so.5.0.10
b5ecd000 b5ece000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5ed7000 b5ee2000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5eea000 b5eed000 r-xp /lib/libattr.so.1.1.0
b5ef5000 b5f89000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f9c000 b5fb9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5fc2000 b5fda000 r-xp /usr/lib/libpng12.so.0.50.0
b5fe3000 b5ff9000 r-xp /lib/libexpat.so.1.5.2
b6003000 b6047000 r-xp /usr/lib/libcurl.so.4.3.0
b6050000 b605a000 r-xp /usr/lib/libXext.so.6.4.0
b6063000 b6067000 r-xp /usr/lib/libXtst.so.6.1.0
b606f000 b6075000 r-xp /usr/lib/libXrender.so.1.3.0
b607e000 b6084000 r-xp /usr/lib/libXrandr.so.2.2.0
b608c000 b608d000 r-xp /usr/lib/libXinerama.so.1.0.0
b6096000 b609f000 r-xp /usr/lib/libXi.so.6.1.0
b60a7000 b60aa000 r-xp /usr/lib/libXfixes.so.3.1.0
b60b2000 b60b4000 r-xp /usr/lib/libXgesture.so.7.0.0
b60bc000 b60be000 r-xp /usr/lib/libXcomposite.so.1.0.0
b60c7000 b60c9000 r-xp /usr/lib/libXdamage.so.1.1.0
b60d1000 b60d8000 r-xp /usr/lib/libXcursor.so.1.0.2
b60e0000 b60e3000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60eb000 b60ef000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60f8000 b60fd000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6107000 b61e8000 r-xp /usr/lib/libX11.so.6.3.0
b61f3000 b6216000 r-xp /usr/lib/libjpeg.so.8.0.2
b622e000 b6244000 r-xp /lib/libz.so.1.2.5
b624c000 b62c1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b62cb000 b62e1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b62ea000 b631e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6327000 b63fa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6405000 b6415000 r-xp /lib/libresolv-2.13.so
b6419000 b6495000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64a1000 b64b9000 r-xp /usr/lib/liblzma.so.5.0.3
b64c2000 b64c5000 r-xp /lib/libcap.so.2.21
b64cd000 b64fa000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6502000 b6503000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b650b000 b6511000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6519000 b6530000 r-xp /usr/lib/liblua-5.1.so
b653a000 b6541000 r-xp /usr/lib/libembryo.so.1.7.99
b6549000 b654f000 r-xp /lib/librt-2.13.so
b6558000 b65ae000 r-xp /usr/lib/libpixman-1.so.0.28.2
b65bb000 b6611000 r-xp /usr/lib/libfreetype.so.6.11.3
b661d000 b6645000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6647000 b6684000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b668d000 b66a0000 r-xp /usr/lib/libfribidi.so.0.3.1
b66a8000 b66c2000 r-xp /usr/lib/libecore_con.so.1.7.99
b66cb000 b66d4000 r-xp /usr/lib/libedbus.so.1.7.99
b66dc000 b672c000 r-xp /usr/lib/libecore_x.so.1.7.99
b672f000 b6733000 r-xp /usr/lib/libvconf.so.0.2.45
b673b000 b674c000 r-xp /usr/lib/libecore_input.so.1.7.99
b6754000 b6759000 r-xp /usr/lib/libecore_file.so.1.7.99
b6761000 b6783000 r-xp /usr/lib/libecore_evas.so.1.7.99
b678c000 b67cd000 r-xp /usr/lib/libeina.so.1.7.99
b67d6000 b67ef000 r-xp /usr/lib/libeet.so.1.7.99
b6800000 b6869000 r-xp /lib/libm-2.13.so
b6872000 b6878000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6881000 b6884000 r-xp /usr/lib/libproc-stat.so.0.2.86
b688c000 b68ae000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68b6000 b68bb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68c3000 b68ed000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68f6000 b690d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6915000 b6920000 r-xp /lib/libunwind.so.8.0.1
b694d000 b6989000 r-xp /usr/lib/libsystemd.so.0.4.0
b6992000 b6aad000 r-xp /lib/libc-2.13.so
b6abb000 b6ac3000 r-xp /lib/libgcc_s-4.6.so.1
b6ac4000 b6ac7000 r-xp /usr/lib/libsmack.so.1.0.0
b6acf000 b6ad5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6add000 b6bad000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6bae000 b6c0b000 r-xp /usr/lib/libedje.so.1.7.99
b6c15000 b6c2c000 r-xp /usr/lib/libecore.so.1.7.99
b6c43000 b6d11000 r-xp /usr/lib/libevas.so.1.7.99
b6d36000 b6e71000 r-xp /usr/lib/libelementary.so.1.7.99
b6e87000 b6e9b000 r-xp /lib/libpthread-2.13.so
b6ea6000 b6ea8000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb0000 b6eb3000 r-xp /usr/lib/libbundle.so.0.1.22
b6ebb000 b6ebd000 r-xp /lib/libdl-2.13.so
b6ec6000 b6ed2000 r-xp /usr/lib/libaul.so.0.1.0
b6ee4000 b6ee9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ef2000 b6ef6000 r-xp /usr/lib/libsys-assert.so
b6eff000 b6f1c000 r-xp /lib/ld-2.13.so
b6f25000 b6f2a000 r-xp /usr/bin/launchpad-loader
b7315000 b746a000 rw-p [heap]
bed6d000 bed8e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3454)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6a096dc) [/lib/libc.so.6] + 0x776dc
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
 clocklist,will,show
09-09 12:17:39.329-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:2, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:39.329-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:2, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:39.409-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:39.409-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:39.409-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:39.409-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:39.429-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
09-09 12:17:39.609-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:39.609-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:39.609-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:39.609-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:39.649-0500 I/watchface-viewer( 3368): viewer-view.cpp: DummyModeAnimationFinished(360) > 
09-09 12:17:39.799-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.809-0500 I/CAPI_WATCH_APPLICATION( 3368): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:39.809-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:39.809-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:17:39.809-0500 I/watchface-viewer( 3368): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:17:39.809-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.809-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1917283
09-09 12:17:39.809-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:39.819-0500 W/W_HOME  ( 1143): scroller.c: scroller_freeze(1848) > freezed:b6ea1905
09-09 12:17:39.849-0500 W/W_HOME  ( 1143): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,show
09-09 12:17:39.849-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:3, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:39.849-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:3, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:17:39.849-0500 W/W_HOME  ( 1143): main.c: home_pause(762) > clock/widget paused
09-09 12:17:39.859-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1917346
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(12) DetentCount(1)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2904), py(0)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2904), py(0)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2904), py(0)
09-09 12:17:39.859-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 13 page
09-09 12:17:39.869-0500 W/WATCH_CORE( 3368): appcore-watch.c: __widget_pause(1001) > widget_pause
09-09 12:17:39.869-0500 E/watchface-loader( 3368): watchface-loader.cpp: OnAppPause(713) > 
09-09 12:17:39.869-0500 E/watchface-viewer( 3368): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:17:39.869-0500 E/watchface-viewer( 3368): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:17:39.869-0500 E/watchface-viewer( 3368): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:17:39.869-0500 I/watchface-viewer( 3368): viewer-part-resource-evas.cpp: StopColonAnimation(1544) > 
09-09 12:17:39.869-0500 E/watchface-viewer( 3368): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:17:39.929-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.929-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1917411
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(12) DetentCount(1)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2982), py(0)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2982), py(0)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2982), py(0)
09-09 12:17:39.939-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 14 page
09-09 12:17:39.979-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.989-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:39.989-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1917462
09-09 12:17:39.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:39.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:39.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:39.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:17:39.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xae198248 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:17:39.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xae198248 : elm_scroller] CurrentPage(12) DetentCount(1)
09-09 12:17:39.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3044), py(0)
09-09 12:17:39.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3044), py(0)
09-09 12:17:39.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xae198248 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3044), py(0)
09-09 12:17:39.999-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xae198248 : elm_scroller] bring in 15 page
09-09 12:17:39.999-0500 W/W_HOME  ( 1143): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
09-09 12:17:40.019-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xae3dda20, elm_image, time_stamp : 1917508
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xae198248 : elm_scroller] rotary callabck is called.
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xae198248 : elm_scroller] block(1)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xae198248 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:17:40.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xae198248 : elm_scroller] content size (w, h)(5684, 360)
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
09-09 12:17:43.499-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103454726f6d147344146
