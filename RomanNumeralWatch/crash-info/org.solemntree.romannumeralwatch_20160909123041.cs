S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 5347
Date: 2016-09-09 12:30:41-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x18c

Register Information
r0   = 0x00000180, r1   = 0x0000000d
r2   = 0x00000010, r3   = 0xb5baf194
r4   = 0x00000180, r5   = 0x00000000
r6   = 0xb787a584, r7   = 0xb786c008
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0xb6ff1dc0
ip   = 0xbeb8dcac, sp   = 0xbeb8dc60
lr   = 0xb6fd70d0, pc   = 0xb6fd69dc
cpsr = 0x20000010

Memory Information
MemTotal:   391348 KB
MemFree:     33112 KB
Buffers:      7692 KB
Cached:      89212 KB
VmPeak:      73060 KB
VmSize:      72516 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14228 KB
VmRSS:       14228 KB
VmData:      21136 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5347 TID = 5347
5347 5413 5419 

Maps Information
b2ca0000 b349f000 rwxp [stack:5419]
b353a000 b3551000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b355e000 b35e5000 rw-s anon_inode:dmabuf
b35e5000 b35f0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b35f9000 b35fb000 r-xp /usr/lib/libgenlock.so
b360e000 b3611000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b361a000 b3e19000 rwxp [stack:5413]
b4019000 b4020000 r-xp /usr/lib/libtbm.so.1.0.0
b4028000 b402a000 r-xp /usr/lib/libdri2.so.0.0.0
b4032000 b4037000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b403f000 b4047000 r-xp /usr/lib/libdrm.so.2.4.0
b404f000 b4058000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b4061000 b406d000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4075000 b407e000 r-xp /usr/lib/libcom-core.so.0.0.1
b560e000 b5614000 r-xp /usr/lib/libwidget.so.1.0.0
b561d000 b5623000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b562b000 b570f000 r-xp /usr/lib/libicuuc.so.51.1
b5724000 b5861000 r-xp /usr/lib/libicui18n.so.51.1
b5871000 b587e000 r-xp /usr/lib/libalarm.so.0.0.0
b5887000 b588e000 r-xp /usr/lib/libappcore-watch.so.1.1
b5a36000 b5a40000 r-xp /lib/libnss_files-2.13.so
b5a49000 b5b18000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5b2e000 b5b52000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b5b000 b5b61000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b69000 b5b6b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b74000 b5b78000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b8a000 b5b8f000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b97000 b5b99000 r-xp /usr/lib/libiniparser.so.0
b5ba2000 b5ba7000 r-xp /usr/lib/libappcore-common.so.1.1
b5baf000 b5bb1000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b5bb9000 b5bbd000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5bca000 b5bcc000 r-xp /usr/lib/libXau.so.6.0.0
b5bd5000 b5bdc000 r-xp /lib/libcrypt-2.13.so
b5c0c000 b5c0e000 r-xp /usr/lib/libiri.so
b5c16000 b5dbe000 r-xp /usr/lib/libcrypto.so.1.0.0
b5dd7000 b5e24000 r-xp /usr/lib/libssl.so.1.0.0
b5e31000 b5e5f000 r-xp /usr/lib/libidn.so.11.5.44
b5e67000 b5e70000 r-xp /usr/lib/libcares.so.2.1.0
b5e79000 b5e8c000 r-xp /usr/lib/libxcb.so.1.1.0
b5e95000 b5e97000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5ea0000 b5ea2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5eab000 b5f77000 r-xp /usr/lib/libxml2.so.2.7.8
b5f84000 b5f86000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f8e000 b5f93000 r-xp /usr/lib/libffi.so.5.0.10
b5f9b000 b5f9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5fa5000 b5fb0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5fb8000 b5fbb000 r-xp /lib/libattr.so.1.1.0
b5fc3000 b6057000 r-xp /usr/lib/libstdc++.so.6.0.16
b606a000 b6087000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6090000 b60a8000 r-xp /usr/lib/libpng12.so.0.50.0
b60b1000 b60c7000 r-xp /lib/libexpat.so.1.5.2
b60d1000 b6115000 r-xp /usr/lib/libcurl.so.4.3.0
b611e000 b6128000 r-xp /usr/lib/libXext.so.6.4.0
b6131000 b6135000 r-xp /usr/lib/libXtst.so.6.1.0
b613d000 b6143000 r-xp /usr/lib/libXrender.so.1.3.0
b614c000 b6152000 r-xp /usr/lib/libXrandr.so.2.2.0
b615a000 b615b000 r-xp /usr/lib/libXinerama.so.1.0.0
b6164000 b616d000 r-xp /usr/lib/libXi.so.6.1.0
b6175000 b6178000 r-xp /usr/lib/libXfixes.so.3.1.0
b6180000 b6182000 r-xp /usr/lib/libXgesture.so.7.0.0
b618a000 b618c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6195000 b6197000 r-xp /usr/lib/libXdamage.so.1.1.0
b619f000 b61a6000 r-xp /usr/lib/libXcursor.so.1.0.2
b61ae000 b61b1000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61b9000 b61bd000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61c6000 b61cb000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61d5000 b62b6000 r-xp /usr/lib/libX11.so.6.3.0
b62c1000 b62e4000 r-xp /usr/lib/libjpeg.so.8.0.2
b62fc000 b6312000 r-xp /lib/libz.so.1.2.5
b631a000 b638f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6399000 b63af000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b63b8000 b63ec000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63f5000 b64c8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b64d3000 b64e3000 r-xp /lib/libresolv-2.13.so
b64e7000 b6563000 r-xp /usr/lib/libgcrypt.so.20.0.3
b656f000 b6587000 r-xp /usr/lib/liblzma.so.5.0.3
b6590000 b6593000 r-xp /lib/libcap.so.2.21
b659b000 b65c8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b65d0000 b65d1000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b65d9000 b65df000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65e7000 b65fe000 r-xp /usr/lib/liblua-5.1.so
b6608000 b660f000 r-xp /usr/lib/libembryo.so.1.7.99
b6617000 b661d000 r-xp /lib/librt-2.13.so
b6626000 b667c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6689000 b66df000 r-xp /usr/lib/libfreetype.so.6.11.3
b66eb000 b6713000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6715000 b6752000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b675b000 b676e000 r-xp /usr/lib/libfribidi.so.0.3.1
b6776000 b6790000 r-xp /usr/lib/libecore_con.so.1.7.99
b6799000 b67a2000 r-xp /usr/lib/libedbus.so.1.7.99
b67aa000 b67fa000 r-xp /usr/lib/libecore_x.so.1.7.99
b67fd000 b6801000 r-xp /usr/lib/libvconf.so.0.2.45
b6809000 b681a000 r-xp /usr/lib/libecore_input.so.1.7.99
b6822000 b6827000 r-xp /usr/lib/libecore_file.so.1.7.99
b682f000 b6851000 r-xp /usr/lib/libecore_evas.so.1.7.99
b685a000 b689b000 r-xp /usr/lib/libeina.so.1.7.99
b68a4000 b68bd000 r-xp /usr/lib/libeet.so.1.7.99
b68ce000 b6937000 r-xp /lib/libm-2.13.so
b6940000 b6946000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b694f000 b6952000 r-xp /usr/lib/libproc-stat.so.0.2.86
b695a000 b697c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6984000 b6989000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6991000 b69bb000 r-xp /usr/lib/libdbus-1.so.3.8.12
b69c4000 b69db000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b69e3000 b69ee000 r-xp /lib/libunwind.so.8.0.1
b6a1b000 b6a57000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a60000 b6b7b000 r-xp /lib/libc-2.13.so
b6b89000 b6b91000 r-xp /lib/libgcc_s-4.6.so.1
b6b92000 b6b95000 r-xp /usr/lib/libsmack.so.1.0.0
b6b9d000 b6ba3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6bab000 b6c7b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c7c000 b6cd9000 r-xp /usr/lib/libedje.so.1.7.99
b6ce3000 b6cfa000 r-xp /usr/lib/libecore.so.1.7.99
b6d11000 b6ddf000 r-xp /usr/lib/libevas.so.1.7.99
b6e04000 b6f3f000 r-xp /usr/lib/libelementary.so.1.7.99
b6f55000 b6f69000 r-xp /lib/libpthread-2.13.so
b6f74000 b6f76000 r-xp /usr/lib/libdlog.so.0.0.0
b6f7e000 b6f81000 r-xp /usr/lib/libbundle.so.0.1.22
b6f89000 b6f8b000 r-xp /lib/libdl-2.13.so
b6f94000 b6fa0000 r-xp /usr/lib/libaul.so.0.1.0
b6fb2000 b6fb7000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fc0000 b6fc4000 r-xp /usr/lib/libsys-assert.so
b6fcd000 b6fea000 r-xp /lib/ld-2.13.so
b6ff3000 b6ff8000 r-xp /usr/bin/launchpad-loader
b777a000 b7910000 rw-p [heap]
beb6e000 beb8f000 rwxp [stack]
beb6e000 beb8f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5347)
Call Stack Count: 6
 0: (0xb6fd69dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0xb6fd70d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0xb6fd7360) [/lib/ld-linux.so.3] + 0xa360
 3: (0xb6fdb5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0xb6fe1a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0xb6acd70c) [/lib/libc.so.6] + 0x6d70c
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
ib  ( 1143): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(260) > Create a panel for panel_id: 1, instance_id: 41
09-09 12:30:24.329-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_initialize(4998) > Initialize the panel with id: 41
09-09 12:30:24.329-0500 W/wnotib  ( 1143): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(275) > Page instance, instance_id [41] has been created.
09-09 12:30:24.329-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 41, application_id: 214, type: 1
09-09 12:30:24.349-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
09-09 12:30:24.349-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 38, application_id: 14883, type: 13
09-09 12:30:24.349-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 39, application_id: 101, type: 13
09-09 12:30:24.349-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 37, application_id: 202, type: 13
09-09 12:30:24.349-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 40, application_id: 202, type: 13
09-09 12:30:24.349-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 41, application_id: 214, type: 13
09-09 12:30:24.359-0500 I/wnotib  ( 1143): w-notification-board-common.c: wnotib_common_get_application_icon(2270) > application_id: 214, thumbnail path: /opt/usr/data/wnoti/.app_icon_214.jpg, width: 58, height: 58
09-09 12:30:24.359-0500 I/wnotib  ( 1143): w-notification-board-common.c: wnotib_common_get_application_icon(2281) > Use the pre-installed icon for 214.
09-09 12:30:24.369-0500 I/wnotib  ( 1143): w-notification-board-common.c: wnotib_common_get_application_icon(2270) > application_id: 214, thumbnail path: /opt/usr/data/wnoti/.app_icon_214.jpg, width: 58, height: 58
09-09 12:30:24.369-0500 I/wnotib  ( 1143): w-notification-board-common.c: wnotib_common_get_application_icon(2281) > Use the pre-installed icon for 214.
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 38, application_id: 14883, type: 12
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 39, application_id: 101, type: 12
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 37, application_id: 202, type: 12
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 40, application_id: 202, type: 12
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 41, application_id: 214, type: 12
09-09 12:30:24.379-0500 W/wnotib  ( 1143): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1383) > Num categories: 5, num total noti: 12
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(867) > Free noti manager data.
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(872) > Free previous notifications.
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(893) > Free previous categories.
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 5, setting_power_saving_mode: 0, show_summary_board: 0
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
09-09 12:30:24.379-0500 I/wnotib  ( 1143): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > num_total_panel: 5.
09-09 12:30:24.379-0500 W/W_HOME  ( 1143): noti_broker.c: _handler_indicator_update(567) > 0x5
09-09 12:30:24.409-0500 W/wnotib  ( 1143): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > unread_count_for_home: 1
09-09 12:30:24.409-0500 W/W_HOME  ( 1143): noti_broker.c: _handler_noti_indicator_show(483) > 
09-09 12:30:24.419-0500 W/W_HOME  ( 1143): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
09-09 12:30:24.419-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:30:24.429-0500 W/W_HOME  ( 1143): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
09-09 12:30:24.429-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:30:24.439-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
09-09 12:30:24.439-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
09-09 12:30:24.459-0500 W/WATCH_CORE( 5216): appcore-watch.c: __widget_pause(1001) > widget_pause
09-09 12:30:24.469-0500 W/WATCH_CORE( 5216): appcore-watch.c: __widget_resume(1012) > widget_resume
09-09 12:30:24.469-0500 I/CAPI_WATCH_APPLICATION( 5216): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:30:24.979-0500 W/SCSD    ( 1705): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
09-09 12:30:24.979-0500 W/SCSD    ( 1705): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
09-09 12:30:24.979-0500 W/SCSD    ( 1705): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
09-09 12:30:24.989-0500 W/SCSD    ( 1705): <util_scs_send:975> sent [11 / 11] bytes. 
09-09 12:30:24.989-0500 I/CAPI_WATCH_APPLICATION( 5216): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:30:25.299-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: main(2131) > package manager server start
09-09 12:30:25.469-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: req_cb(650) > req_id=[org.solemntree.romannumeralwatch_-2140328329], req_type=[12], pkg_type=[rpm], pkgid=[org.solemntree.romannumeralwatch], args=[], cookie=[/vxK6UlNg4DX/WKjftC18lmhBVc=], backend_flag=[0]
09-09 12:30:25.479-0500 E/PKGMGR_SERVER( 5411): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.solemntree.romannumeralwatch]
09-09 12:30:25.489-0500 E/PKGMGR  ( 5408): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.solemntree.romannumeralwatch, -1]
09-09 12:30:25.589-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:25.599-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5216
09-09 12:30:25.599-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:30:25.609-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 5
09-09 12:30:25.609-0500 E/AUL_AMD (  934): amd_request.c: __app_process_by_pid(193) > pid(3918) is dead. cmd(5) is canceled
09-09 12:30:25.609-0500 E/PKGMGR_SERVER( 5411): pkgmgr-server.c: __terminate_app(1393) > [0;31m[__terminate_app(): 1393](ret < 0) aul_terminate_pid[-3] fail
09-09 12:30:25.609-0500 E/PKGMGR_SERVER( 5411): [0;m
09-09 12:30:25.609-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 5
09-09 12:30:25.609-0500 W/CAPI_WATCH_APPLICATION( 5216): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
09-09 12:30:25.609-0500 W/WATCH_CORE( 5216): appcore-watch.c: __widget_destroy(992) > widget_destory
09-09 12:30:25.609-0500 E/WIDGET_PROVIDER_APP( 5216): client.c: client_fini(1175) > Provider is not initialized
09-09 12:30:25.609-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 22
09-09 12:30:25.609-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(890) > app status : 4
09-09 12:30:25.609-0500 W/AUL_AMD (  934): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(5216), cmd(4)
09-09 12:30:25.609-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 4
09-09 12:30:25.619-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:25.629-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5216
09-09 12:30:25.689-0500 E/AUL_AMD (  934): amd_launch.c: __reply_handler(898) > recv error : Connection reset by peer
09-09 12:30:25.689-0500 W/AUL_AMD (  934): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(5216), cmd(4)
09-09 12:30:25.689-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
09-09 12:30:25.699-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:30:25.719-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:30:25.719-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:30:25.719-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:30:25.759-0500 E/RESOURCED(  935): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.solemntree.romannumeralwatch, table num : 2
09-09 12:30:25.759-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:30:25.769-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:30:25.769-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
09-09 12:30:25.769-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:30:25.789-0500 I/CAPI_WATCH_APPLICATION( 5347): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:30:25.879-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:25.879-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:25.879-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5216
09-09 12:30:25.879-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:30:25.919-0500 W/WATCH_CORE( 5347): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:30:25.919-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [2624.825684] pkgname: org.solemntree.romannumeralwatch, id: file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_2624.825684.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://23068776:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:30:25.919-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[2624.825684] pkgname[org.solemntree.romannumeralwatch], id[file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_2624.825684.png] content[] cluster[user,created] category[default] widget_fname[pixmap://23068776:4] gbar_fname[]
09-09 12:30:25.929-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
09-09 12:30:25.929-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
09-09 12:30:25.979-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:25.989-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:25.999-0500 W/WATCH_CORE( 5347): appcore-watch.c: __widget_create(976) > widget_create done
09-09 12:30:26.069-0500 I/WATCH_CORE( 5347): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
09-09 12:30:26.069-0500 I/WATCH_CORE( 5347): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
09-09 12:30:26.069-0500 I/WATCH_CORE( 5347): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
09-09 12:30:26.089-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.099-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.209-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.209-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.319-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.319-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.429-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.429-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.529-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.539-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.639-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.649-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.749-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.759-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.859-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.869-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.869-0500 W/AUL_AMD (  934): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-09 12:30:26.869-0500 W/AUL_AMD (  934): amd_launch.c: __grab_timeout_handler(1375) > back key ungrab error
09-09 12:30:26.919-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.929-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.929-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:30:26.969-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:26.979-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:26.999-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:30:26.999-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:30:27.029-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:30:27.029-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:30:27.059-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:30:27.059-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:30:27.059-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:30:27.059-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:30:27.059-0500 E/EFL     ( 5431): elementary<5431> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:30:27.079-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.079-0500 E/EFL     ( 5431): elementary<5431> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:30:27.089-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:27.089-0500 E/EFL     ( 5431): elementary<5431> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:30:27.089-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:30:27.109-0500 E/EFL     ( 5431): elementary<5431> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:30:27.119-0500 E/EFL     ( 5431): elementary<5431> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:30:27.119-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:30:27.119-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:30:27.119-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:30:27.119-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:30:27.119-0500 E/EFL     ( 5431): elementary<5431> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:30:27.119-0500 I/AUL_PAD ( 5431): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:30:27.189-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.199-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:27.299-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.309-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:27.409-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.439-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:27.519-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:30:27.539-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.559-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:27.609-0500 W/AUL_AMD (  934): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
09-09 12:30:27.669-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.709-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:27.809-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.829-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:27.939-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:27.959-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.069-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:28.089-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.199-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:28.219-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.329-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:28.349-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.459-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:28.479-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.589-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:28.619-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.719-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:28.749-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.849-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:28.879-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:28.989-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.009-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:29.119-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.159-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:29.259-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.269-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:29.379-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.409-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:29.509-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.519-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:30:29.519-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:29.629-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.639-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:29.739-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.769-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:29.879-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:29.909-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.019-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.039-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.149-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.179-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.279-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.299-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.409-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.439-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.549-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.569-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.669-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.679-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.779-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.799-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:30.899-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:30.929-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.039-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:31.059-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.169-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:31.189-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.289-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:31.309-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.419-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:31.449-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.479-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20152) > wear_monitor_status update[0] = 1 -> 2
09-09 12:30:31.479-0500 E/WMS     (  899): wms_msg_broker.c: wms_msg_broker_send(1743) > 
09-09 12:30:31.479-0500 E/WMS     (  899): ==========
09-09 12:30:31.479-0500 E/WMS     (  899): ##WMS SEND : mgr_gear_wear_onoff_req
09-09 12:30:31.479-0500 E/WMS     (  899): ==========
09-09 12:30:31.479-0500 E/WMS     (  899): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
09-09 12:30:31.519-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:30:31.519-0500 W/SCSD    ( 1705): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
09-09 12:30:31.519-0500 W/SCSD    ( 1705): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
09-09 12:30:31.519-0500 W/SCSD    ( 1705): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
09-09 12:30:31.529-0500 W/SCSD    ( 1705): <util_scs_send:975> sent [63 / 63] bytes. 
09-09 12:30:31.559-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:31.579-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.599-0500 W/SHealth_Service( 1536): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
09-09 12:30:31.609-0500 E/SHealth_Service( 1536): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
09-09 12:30:31.689-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:31.699-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.809-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:30:31.839-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5347
09-09 12:30:31.959-0500 E/PKGMGR_SERVER( 5411): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
09-09 12:30:31.999-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5411]
09-09 12:30:33.519-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
09-09 12:30:33.519-0500 E/PKGMGR_SERVER( 5410): pkgmgr-server.c: main(2185) > package manager server terminated.
09-09 12:30:36.719-0500 E/PKGMGR  ( 5507): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
09-09 12:30:36.849-0500 E/PKGMGR_SERVER( 5513): pkgmgr-server.c: main(2131) > package manager server start
09-09 12:30:36.919-0500 E/PKGMGR_SERVER( 5513): pkgmgr-server.c: req_cb(650) > req_id=[org.solemntree.romannumeralwatch_-2128723203], req_type=[1], pkg_type=[rpm], pkgid=[org.solemntree.romannumeralwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.solemntree.romannumeralwatch_-2128723203' '-r' 'org.solemntree.romannumeralwatch'], cookie=[GuGF33EqiIrvswEyTC0G4qgOgo4=], backend_flag=[0]
09-09 12:30:36.919-0500 E/PKGMGR  ( 5513): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.solemntree.romannumeralwatch]
09-09 12:30:36.919-0500 E/PKGMGR_SERVER( 5513): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.solemntree.romannumeralwatch 
09-09 12:30:36.919-0500 E/PKGMGR  ( 5507): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[55070002]
09-09 12:30:36.929-0500 E/PKGMGR_SERVER( 5515): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.solemntree.romannumeralwatch]
09-09 12:30:37.069-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
09-09 12:30:37.069-0500 W/AUL_AMD (  934): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
09-09 12:30:37.079-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.solemntree.romannumeralwatch is being updateded:0
09-09 12:30:37.089-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
09-09 12:30:37.269-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
09-09 12:30:37.279-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
09-09 12:30:37.279-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
09-09 12:30:37.279-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
09-09 12:30:37.279-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 1
09-09 12:30:37.279-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 1
09-09 12:30:37.279-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 20 1
09-09 12:30:37.279-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 1
09-09 12:30:37.299-0500 W/WATCH_CORE( 5347): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
09-09 12:30:37.299-0500 I/WATCH_CORE( 5347): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
09-09 12:30:37.299-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: OnReceiveDisplayChanged(963) > [0;32mINFO: LCDOff receive data : -1226499316[0;m
09-09 12:30:37.299-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: OnReceiveDisplayChanged(964) > [0;32mINFO: WakeupServiceStop[0;m
09-09 12:30:37.299-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: WakeupServiceStop(401) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
09-09 12:30:37.299-0500 E/PKGMGR_CERT( 5515): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
09-09 12:30:37.309-0500 W/W_HOME  ( 1143): dbus.c: _dbus_message_recv_cb(204) > LCD off
09-09 12:30:37.309-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_disable_timer_del(151) > timer del
09-09 12:30:37.309-0500 W/W_HOME  ( 1143): gesture.c: _manual_render_enable(133) > 1
09-09 12:30:37.309-0500 W/W_HOME  ( 1143): event_manager.c: _lcd_off_cb(699) > lcd state: 0
09-09 12:30:37.309-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:30:37.309-0500 W/STARTER ( 1092): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
09-09 12:30:37.309-0500 W/STARTER ( 1092): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
09-09 12:30:37.309-0500 E/STARTER ( 1092): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
09-09 12:30:37.309-0500 W/STARTER ( 1092): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
09-09 12:30:37.309-0500 W/STARTER ( 1092): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
09-09 12:30:37.319-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
09-09 12:30:37.319-0500 I/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
09-09 12:30:37.319-0500 W/TIZEN_N_SOUND_MANAGER( 1604): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-09 12:30:37.319-0500 W/WAKEUP-SERVICE( 1604): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 0[0;m
09-09 12:30:37.319-0500 I/HIGEAR  ( 1604): WakeupService.cpp: WakeupServiceStop(405) > [svoice:Application:WakeupServiceStop:IN]
09-09 12:30:37.449-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5431
09-09 12:30:37.589-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5217
09-09 12:30:37.599-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1261]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
09-09 12:30:37.599-0500 W/STARTER ( 1092): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
09-09 12:30:37.599-0500 W/STARTER ( 1092): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
09-09 12:30:37.599-0500 W/STARTER ( 1092): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
09-09 12:30:37.599-0500 W/STARTER ( 1092): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
09-09 12:30:37.599-0500 I/APP_CORE( 1143): appcore-efl.c: __do_app(429) > [APP 1143] Event: PAUSE State: RUNNING
09-09 12:30:37.599-0500 I/CAPI_APPFW_APPLICATION( 1143): app_main.c: app_appcore_pause(202) > app_appcore_pause
09-09 12:30:37.599-0500 W/W_HOME  ( 1143): main.c: _appcore_pause_cb(692) > appcore pause
09-09 12:30:37.599-0500 W/W_HOME  ( 1143): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
09-09 12:30:37.609-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:30:37.609-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:30:37.609-0500 W/W_HOME  ( 1143): main.c: home_pause(762) > clock/widget paused
09-09 12:30:37.609-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:30:37.609-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:37.609-0500 E/CAPI_APPFW_APP_CONTROL( 1261): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
09-09 12:30:37.609-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1261]   [com.samsung.w-home]register msg port [false][0m
09-09 12:30:37.609-0500 W/GESTURE (  252): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
09-09 12:30:37.659-0500 I/SHealth_Common( 1536): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
09-09 12:30:37.659-0500 I/SHealth_Service( 1536): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
09-09 12:30:37.719-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:30:37.719-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:30:37.749-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:30:37.749-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:30:37.779-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:30:37.789-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:30:37.789-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:30:37.789-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:30:37.789-0500 E/EFL     ( 5519): elementary<5519> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:30:37.809-0500 E/EFL     ( 5519): elementary<5519> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:30:37.809-0500 E/EFL     ( 5519): elementary<5519> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:30:37.809-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:30:37.839-0500 E/EFL     ( 5519): elementary<5519> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:30:37.849-0500 E/EFL     ( 5519): elementary<5519> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:30:37.849-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:30:37.849-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:30:37.849-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:30:37.849-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:30:37.849-0500 E/EFL     ( 5519): elementary<5519> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:30:37.849-0500 I/AUL_PAD ( 5519): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:30:37.979-0500 I/efl-extension( 5520): efl_extension.c: eext_mod_init(40) > Init
09-09 12:30:37.999-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:558 elm_quicklaunch_init() eet_init done.
09-09 12:30:37.999-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
09-09 12:30:38.019-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
09-09 12:30:38.019-0500 I/UXT     ( 5520): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
09-09 12:30:38.019-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
09-09 12:30:38.059-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
09-09 12:30:38.059-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
09-09 12:30:38.059-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
09-09 12:30:38.059-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
09-09 12:30:38.059-0500 E/EFL     ( 5520): elementary<5520> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
09-09 12:30:38.079-0500 E/EFL     ( 5520): elementary<5520> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
09-09 12:30:38.089-0500 E/EFL     ( 5520): elementary<5520> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
09-09 12:30:38.089-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
09-09 12:30:38.109-0500 I/APP_CORE( 1143): appcore-efl.c: __do_app(429) > [APP 1143] Event: MEM_FLUSH State: PAUSED
09-09 12:30:38.119-0500 E/EFL     ( 5520): elementary<5520> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
09-09 12:30:38.119-0500 E/EFL     ( 5520): elementary<5520> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
09-09 12:30:38.119-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
09-09 12:30:38.119-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
09-09 12:30:38.119-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
09-09 12:30:38.119-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
09-09 12:30:38.119-0500 E/EFL     ( 5520): elementary<5520> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
09-09 12:30:38.119-0500 I/AUL_PAD ( 5520): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
09-09 12:30:38.149-0500 I/Adreno-EGL( 5520): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
09-09 12:30:38.149-0500 I/Adreno-EGL( 5520): OpenGL ES Shader Compiler Version: E031.24.00.16
09-09 12:30:38.149-0500 I/Adreno-EGL( 5520): Build Date: 09/02/15 Wed
09-09 12:30:38.149-0500 I/Adreno-EGL( 5520): Local Branch: 
09-09 12:30:38.149-0500 I/Adreno-EGL( 5520): Remote Branch: 
09-09 12:30:38.149-0500 I/Adreno-EGL( 5520): Local Patches: 
09-09 12:30:38.149-0500 I/Adreno-EGL( 5520): Reconstruct Branch: 
09-09 12:30:39.009-0500 E/rpm-installer( 5515): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
09-09 12:30:39.519-0500 E/PKGMGR_SERVER( 5513): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:30:41.519-0500 E/PKGMGR_SERVER( 5513): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:30:41.819-0500 E/PKGMGR_SERVER( 5513): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5515]
09-09 12:30:41.859-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.solemntree.romannumeralwatch is updated, need to check validation
09-09 12:30:41.859-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.solemntree.romannumeralwatch
09-09 12:30:41.869-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
09-09 12:30:41.869-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, COMPLETED]
09-09 12:30:41.869-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6915) > package install complete
09-09 12:30:41.869-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_package_install_event(4787) > 
09-09 12:30:41.869-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
09-09 12:30:41.929-0500 W/W_HOME  ( 1143): clock_event.c: _pkgmgr_event_cb(249) > clock org.solemntree.romannumeralwatch is updated, preload:0 update:0 event->update:0
09-09 12:30:41.939-0500 E/STARTER ( 1092): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
09-09 12:30:41.989-0500 E/PKGMGR_INFO(  898): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-09 12:30:41.999-0500 E/APPS    ( 1143): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
09-09 12:30:42.199-0500 W/CRASH_MANAGER( 5523): worker.c: worker_job(1199) > 1105347726f6d147344224
