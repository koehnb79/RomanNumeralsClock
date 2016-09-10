S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3652
Date: 2016-09-09 12:18:55-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbef3907c, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbef38b48, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb5b944d0
r10  = 0x0000000c, fp   = 0xbef38b3c
ip   = 0x0000000c, sp   = 0xbef385c8
lr   = 0xb6a6af5c, pc   = 0xb6aa56dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:     13100 KB
Buffers:      9440 KB
Cached:      89592 KB
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
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3652 TID = 3652
3652 3883 

Maps Information
b3508000 b351f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b352c000 b35b3000 rw-s anon_inode:dmabuf
b35b3000 b35be000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b35c7000 b35c9000 r-xp /usr/lib/libgenlock.so
b35dc000 b35df000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b35e8000 b3de7000 rwxp [stack:3883]
b3fe7000 b3fee000 r-xp /usr/lib/libtbm.so.1.0.0
b3ff6000 b3ff8000 r-xp /usr/lib/libdri2.so.0.0.0
b4000000 b4005000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b400d000 b4015000 r-xp /usr/lib/libdrm.so.2.4.0
b401d000 b4026000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b402f000 b403b000 r-xp /usr/lib/libwidget_service.so.1.0.0
b4043000 b404c000 r-xp /usr/lib/libcom-core.so.0.0.1
b55dc000 b55e2000 r-xp /usr/lib/libwidget.so.1.0.0
b55eb000 b55f1000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b55f9000 b56dd000 r-xp /usr/lib/libicuuc.so.51.1
b56f2000 b582f000 r-xp /usr/lib/libicui18n.so.51.1
b583f000 b584c000 r-xp /usr/lib/libalarm.so.0.0.0
b5855000 b585c000 r-xp /usr/lib/libappcore-watch.so.1.1
b5a04000 b5a0e000 r-xp /lib/libnss_files-2.13.so
b5a17000 b5ae6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5afc000 b5b20000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b29000 b5b2f000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b37000 b5b39000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b42000 b5b46000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b58000 b5b5d000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b65000 b5b67000 r-xp /usr/lib/libiniparser.so.0
b5b70000 b5b75000 r-xp /usr/lib/libappcore-common.so.1.1
b5b7d000 b5b7f000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b5b87000 b5b8b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b98000 b5b9a000 r-xp /usr/lib/libXau.so.6.0.0
b5ba3000 b5baa000 r-xp /lib/libcrypt-2.13.so
b5bda000 b5bdc000 r-xp /usr/lib/libiri.so
b5be4000 b5d8c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5da5000 b5df2000 r-xp /usr/lib/libssl.so.1.0.0
b5dff000 b5e2d000 r-xp /usr/lib/libidn.so.11.5.44
b5e35000 b5e3e000 r-xp /usr/lib/libcares.so.2.1.0
b5e47000 b5e5a000 r-xp /usr/lib/libxcb.so.1.1.0
b5e63000 b5e65000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e6e000 b5e70000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e79000 b5f45000 r-xp /usr/lib/libxml2.so.2.7.8
b5f52000 b5f54000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f5c000 b5f61000 r-xp /usr/lib/libffi.so.5.0.10
b5f69000 b5f6a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f73000 b5f7e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f86000 b5f89000 r-xp /lib/libattr.so.1.1.0
b5f91000 b6025000 r-xp /usr/lib/libstdc++.so.6.0.16
b6038000 b6055000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b605e000 b6076000 r-xp /usr/lib/libpng12.so.0.50.0
b607f000 b6095000 r-xp /lib/libexpat.so.1.5.2
b609f000 b60e3000 r-xp /usr/lib/libcurl.so.4.3.0
b60ec000 b60f6000 r-xp /usr/lib/libXext.so.6.4.0
b60ff000 b6103000 r-xp /usr/lib/libXtst.so.6.1.0
b610b000 b6111000 r-xp /usr/lib/libXrender.so.1.3.0
b611a000 b6120000 r-xp /usr/lib/libXrandr.so.2.2.0
b6128000 b6129000 r-xp /usr/lib/libXinerama.so.1.0.0
b6132000 b613b000 r-xp /usr/lib/libXi.so.6.1.0
b6143000 b6146000 r-xp /usr/lib/libXfixes.so.3.1.0
b614e000 b6150000 r-xp /usr/lib/libXgesture.so.7.0.0
b6158000 b615a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6163000 b6165000 r-xp /usr/lib/libXdamage.so.1.1.0
b616d000 b6174000 r-xp /usr/lib/libXcursor.so.1.0.2
b617c000 b617f000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6187000 b618b000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6194000 b6199000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61a3000 b6284000 r-xp /usr/lib/libX11.so.6.3.0
b628f000 b62b2000 r-xp /usr/lib/libjpeg.so.8.0.2
b62ca000 b62e0000 r-xp /lib/libz.so.1.2.5
b62e8000 b635d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6367000 b637d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6386000 b63ba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63c3000 b6496000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b64a1000 b64b1000 r-xp /lib/libresolv-2.13.so
b64b5000 b6531000 r-xp /usr/lib/libgcrypt.so.20.0.3
b653d000 b6555000 r-xp /usr/lib/liblzma.so.5.0.3
b655e000 b6561000 r-xp /lib/libcap.so.2.21
b6569000 b6596000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b659e000 b659f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b65a7000 b65ad000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65b5000 b65cc000 r-xp /usr/lib/liblua-5.1.so
b65d6000 b65dd000 r-xp /usr/lib/libembryo.so.1.7.99
b65e5000 b65eb000 r-xp /lib/librt-2.13.so
b65f4000 b664a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6657000 b66ad000 r-xp /usr/lib/libfreetype.so.6.11.3
b66b9000 b66e1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66e3000 b6720000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6729000 b673c000 r-xp /usr/lib/libfribidi.so.0.3.1
b6744000 b675e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6767000 b6770000 r-xp /usr/lib/libedbus.so.1.7.99
b6778000 b67c8000 r-xp /usr/lib/libecore_x.so.1.7.99
b67cb000 b67cf000 r-xp /usr/lib/libvconf.so.0.2.45
b67d7000 b67e8000 r-xp /usr/lib/libecore_input.so.1.7.99
b67f0000 b67f5000 r-xp /usr/lib/libecore_file.so.1.7.99
b67fd000 b681f000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6828000 b6869000 r-xp /usr/lib/libeina.so.1.7.99
b6872000 b688b000 r-xp /usr/lib/libeet.so.1.7.99
b689c000 b6905000 r-xp /lib/libm-2.13.so
b690e000 b6914000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b691d000 b6920000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6928000 b694a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6952000 b6957000 r-xp /usr/lib/libxdgmime.so.1.1.0
b695f000 b6989000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6992000 b69a9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b69b1000 b69bc000 r-xp /lib/libunwind.so.8.0.1
b69e9000 b6a25000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a2e000 b6b49000 r-xp /lib/libc-2.13.so
b6b57000 b6b5f000 r-xp /lib/libgcc_s-4.6.so.1
b6b60000 b6b63000 r-xp /usr/lib/libsmack.so.1.0.0
b6b6b000 b6b71000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b79000 b6c49000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c4a000 b6ca7000 r-xp /usr/lib/libedje.so.1.7.99
b6cb1000 b6cc8000 r-xp /usr/lib/libecore.so.1.7.99
b6cdf000 b6dad000 r-xp /usr/lib/libevas.so.1.7.99
b6dd2000 b6f0d000 r-xp /usr/lib/libelementary.so.1.7.99
b6f23000 b6f37000 r-xp /lib/libpthread-2.13.so
b6f42000 b6f44000 r-xp /usr/lib/libdlog.so.0.0.0
b6f4c000 b6f4f000 r-xp /usr/lib/libbundle.so.0.1.22
b6f57000 b6f59000 r-xp /lib/libdl-2.13.so
b6f62000 b6f6e000 r-xp /usr/lib/libaul.so.0.1.0
b6f80000 b6f85000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8e000 b6f92000 r-xp /usr/lib/libsys-assert.so
b6f9b000 b6fb8000 r-xp /lib/ld-2.13.so
b6fc1000 b6fc6000 r-xp /usr/bin/launchpad-loader
b8f0d000 b9062000 rw-p [heap]
bef19000 bef3a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3652)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6aa56dc) [/lib/libc.so.6] + 0x776dc
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
    ( 1705): Scone_Log.cpp: dump(2972) > SNL :: handshake - c( 3 ) desc( 2016-09-09 12:18:48.143714 )
09-09 12:18:49.619-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: handshake - received_n_id( 0 )
09-09 12:18:49.619-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: handshake - set tci
09-09 12:18:49.619-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: handshake - target version(0.2.7.3)
09-09 12:18:49.619-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: noti_pc - Call g(0db213ea37a611b2ae99), i(39kc4o8c10), id(3), type(1)
09-09 12:18:49.619-0500 W/SNL_W   ( 1705): <peerConnNotify_i:1109> peerConnNotify_i - begin conn_id( 3 ) conn_type( 1 )
09-09 12:18:49.619-0500 W/SNL_W   ( 1705): <appendConnIdData:171> ==== appendConnIdData Start conn_id[3], time[1473441529] ====
09-09 12:18:49.619-0500 W/SNL_W   ( 1705): <appendConnIdData:184> ==== appendConnIdData end res[0] ====
09-09 12:18:49.619-0500 W/SCSD    ( 1705): <on_peerConnNotify:345> mapped_port: 7080
09-09 12:18:49.619-0500 W/SCSD    ( 1705): <on_peerConnNotify:346> nat_type: 0
09-09 12:18:49.619-0500 W/SCSD    ( 1705): <on_peerConnNotify:347> conn_type: 1 (tcp:1, udp:2, turn_relay:4, plain_udp:8, turn_udp: 16)
09-09 12:18:49.619-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: noti_pc - Res( 0 )
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <_emit_peer_connect_cb:305> 
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <_connected_cb:449> SCS Peer Connected !!!
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <_connected_cb:450>  - peer_id: [SAP_B2C73240603F30CDC1569FC351CAA33A]
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <_connected_cb:451>  - conn_id: 3
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <util_dbus_set_connection_status:267> set connection_status: 1
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
09-09 12:18:49.699-0500 W/SCSD    ( 1705): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
09-09 12:18:49.699-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
09-09 12:18:49.709-0500 W/SCSD    ( 1705): <util_scs_send:975> sent [63 / 63] bytes. 
09-09 12:18:49.709-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
09-09 12:18:49.709-0500 I/W_INDICATOR( 1093): windicator.c: windicator_is_lo_connected(757) > [windicator_is_lo_connected:757] Connected target vendor : samsung
09-09 12:18:49.709-0500 W/SCSD    ( 1705): <recv_thread:174> time=1473441529, thread_id=3852, conn_id: 3
09-09 12:18:49.709-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
09-09 12:18:49.709-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
09-09 12:18:49.709-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(95) > [windicator_scs_update:95] svc type : 7
09-09 12:18:49.709-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
09-09 12:18:49.709-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
09-09 12:18:49.709-0500 W/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 0
09-09 12:18:49.709-0500 I/W_INDICATOR( 1093): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(374) > network status : 0
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(379) > sap_connected : 1
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(385) > sap connectivity type : 16
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(391) > network status : 2
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(398) > svc type : 7
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(405) > scs login : 1
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_event.c: _wmanager_connectivity_get(433) > network connection via WIFI : no checking svc_type
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
09-09 12:18:49.709-0500 W/W_HOME  ( 1143): clock_indicator.c: clock_indicator_pop(370) > icon:5(0) is popped from clock indicator
09-09 12:18:49.749-0500 I/watchface-viewer( 3653): viewer-view.cpp: DummyModeAnimationFinished(360) > 
09-09 12:18:49.799-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:18:49.799-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:18:49.799-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:18:49.799-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:18:49.869-0500 W/W_HOME  ( 1143): scroller.c: scroller_freeze(1848) > freezed:b6ea1905
09-09 12:18:49.909-0500 W/W_HOME  ( 1143): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,show
09-09 12:18:49.909-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:3, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:18:49.909-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:3, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:18:49.909-0500 W/W_HOME  ( 1143): main.c: home_pause(762) > clock/widget paused
09-09 12:18:49.929-0500 W/WATCH_CORE( 3653): appcore-watch.c: __widget_pause(1001) > widget_pause
09-09 12:18:49.929-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppPause(713) > 
09-09 12:18:49.929-0500 E/watchface-viewer( 3653): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:18:49.929-0500 E/watchface-viewer( 3653): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:18:49.929-0500 E/watchface-viewer( 3653): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:18:49.929-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: StopColonAnimation(1544) > 
09-09 12:18:49.929-0500 E/watchface-viewer( 3653): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
09-09 12:18:49.989-0500 W/W_HOME  ( 1143): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
09-09 12:18:50.639-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: sc_si - Call()
09-09 12:18:50.639-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: sc_si - Res()
09-09 12:18:50.639-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: handshake. - seq(0) conn_id(4) stub_status(1) p(4) nid(0)
09-09 12:18:50.639-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: handshake. - conn_id(4) fic(0) r_timeout(10000)
09-09 12:18:50.649-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: handshake - recv.1 c( 4 ) res( -12 )
09-09 12:18:50.649-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: sc_dis connid( 4 ), way( 4)
09-09 12:18:50.649-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: sc_dis .
09-09 12:18:50.879-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1988365
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(12) DetentCount(1)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2904), py(0)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2904), py(0)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2904), py(0)
09-09 12:18:50.899-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 13 page
09-09 12:18:50.949-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1988430
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(12) DetentCount(1)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2976), py(0)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2976), py(0)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(2976), py(0)
09-09 12:18:50.979-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 14 page
09-09 12:18:51.029-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1988517
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(12) DetentCount(1)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3039), py(0)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3039), py(0)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3039), py(0)
09-09 12:18:51.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 15 page
09-09 12:18:51.319-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xac204770 : elm_scroller] CurrentPage(15)
09-09 12:18:51.449-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1988930
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(15) DetentCount(1)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3630), py(0)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3630), py(0)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3630), py(0)
09-09 12:18:51.449-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 16 page
09-09 12:18:51.489-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.499-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1988972
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(15) DetentCount(1)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3675), py(0)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3675), py(0)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(3675), py(0)
09-09 12:18:51.509-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 17 page
09-09 12:18:51.789-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xac204770 : elm_scroller] CurrentPage(17)
09-09 12:18:51.989-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1989468
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(17) DetentCount(1)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4114), py(0)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4114), py(0)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4114), py(0)
09-09 12:18:51.989-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 18 page
09-09 12:18:52.019-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1989508
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(17) DetentCount(1)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4132), py(0)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4132), py(0)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4132), py(0)
09-09 12:18:52.039-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 19 page
09-09 12:18:52.099-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1989580
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(17) DetentCount(1)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4321), py(0)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4321), py(0)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4321), py(0)
09-09 12:18:52.129-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 20 page
09-09 12:18:52.149-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20152) > wear_monitor_status update[0] = 1 -> 2
09-09 12:18:52.149-0500 E/WMS     (  899): wms_msg_broker.c: wms_msg_broker_send(1743) > 
09-09 12:18:52.149-0500 E/WMS     (  899): ==========
09-09 12:18:52.149-0500 E/WMS     (  899): ##WMS SEND : mgr_gear_wear_onoff_req
09-09 12:18:52.149-0500 E/WMS     (  899): ==========
09-09 12:18:52.149-0500 E/WMS     (  899): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
09-09 12:18:52.159-0500 W/SCSD    ( 1705): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
09-09 12:18:52.159-0500 W/SCSD    ( 1705): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
09-09 12:18:52.159-0500 W/SCSD    ( 1705): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
09-09 12:18:52.169-0500 W/SCSD    ( 1705): <util_scs_send:975> sent [63 / 63] bytes. 
09-09 12:18:52.189-0500 W/SHealth_Service( 1536): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
09-09 12:18:52.189-0500 E/SHealth_Service( 1536): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
09-09 12:18:52.409-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xac204770 : elm_scroller] CurrentPage(20)
09-09 12:18:52.959-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1990435
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(20) DetentCount(1)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4840), py(0)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4840), py(0)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4840), py(0)
09-09 12:18:52.959-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 21 page
09-09 12:18:53.069-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1990549
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(20) DetentCount(1)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4981), py(0)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4981), py(0)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(4981), py(0)
09-09 12:18:53.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 22 page
09-09 12:18:53.349-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xac204770 : elm_scroller] CurrentPage(22)
09-09 12:18:54.069-0500 I/efl-extension( 1683): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0xadfa5020, elm_image, time_stamp : 1991552
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xac204770 : elm_scroller] rotary callabck is called.
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xac204770 : elm_scroller] block(1)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xac204770 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xac204770 : elm_scroller] content size (w, h)(5684, 360)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xac204770 : elm_scroller] viewport size (w, h)(360, 360)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xac204770 : elm_scroller] CurrentPage(22) DetentCount(-1)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5324), py(0)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5324), py(0)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xac204770 : elm_scroller] mx(5324), my(0), minx(0), miny(0), px(5324), py(0)
09-09 12:18:54.069-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xac204770 : elm_scroller] bring in 21 page
09-09 12:18:54.349-0500 I/efl-extension( 1143): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xac204770 : elm_scroller] CurrentPage(21)
09-09 12:18:54.989-0500 W/W_HOME  ( 1143): rotary.c: rotary_deattach(156) > rotary_deattach:0xac204770
09-09 12:18:54.989-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_vconf_clocks_set_idle(6474) > ConnectionType[16] is not BT, ignore this callback.
09-09 12:18:54.989-0500 I/efl-extension( 1143): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb89f0d48, elm_box, _activated_obj : 0xadfa5020, activated : 1
09-09 12:18:54.999-0500 I/efl-extension( 1143): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-09 12:18:54.999-0500 E/wnotib  ( 1143): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
09-09 12:18:54.999-0500 I/wnotib  ( 1143): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 38, 14883.
09-09 12:18:54.999-0500 I/wnotib  ( 1143): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
09-09 12:18:54.999-0500 I/MESSAGE_PORT( 1143): MessagePortProxy.cpp: IsLocalPortRegisted(695) > MessagePort name is already registered.
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.w-home:w-home::localport], client = 1143
09-09 12:18:54.999-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:18:54.999-0500 E/EFL     ( 1143): edje<1143> edje_util.c:3770 edje_object_size_min_restricted_calc() group page has a non-fixed part 'clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:18:55.059-0500 W/W_HOME  ( 1143): clock_service.c: clock_service_event_handler(821) > scroller freeze off
09-09 12:18:55.059-0500 W/W_HOME  ( 1143): scroller.c: scroller_unfreeze(1871) > unfreezed:b6e7c92f
09-09 12:18:55.059-0500 W/W_HOME  ( 1143): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: org.solemntree.romannumeralwatch 1 0 0 1
09-09 12:18:55.059-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:18:55.059-0500 E/W_HOME  ( 1143): clock_service.c: _clock_provider_change(396) > clock will be changed to org.solemntree.romannumeralwatch
09-09 12:18:55.079-0500 E/W_HOME  ( 1143): dbox.c: widget_create(365) > add-viewer info none: org.solemntree.romannumeralwatch
09-09 12:18:55.079-0500 W/W_HOME  ( 1143): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
09-09 12:18:55.079-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
09-09 12:18:55.079-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
09-09 12:18:55.079-0500 E/W_HOME  ( 1143): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
09-09 12:18:55.079-0500 E/W_HOME  ( 1143): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
09-09 12:18:55.079-0500 E/W_HOME  ( 1143): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
09-09 12:18:55.079-0500 W/W_HOME  ( 1143): cs_broker.c: _wms_clock_vconf_cb(283) > 
09-09 12:18:55.079-0500 E/CLOCK-LIST( 1143): clocklist_main.c: clock_setting_event(3764) > proxy image is not deleted. Ignore event
09-09 12:18:55.079-0500 W/W_HOME  ( 1143): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,will,hide
09-09 12:18:55.079-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:18:55.079-0500 W/W_HOME  ( 1143): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-09 12:18:55.079-0500 W/W_HOME  ( 1143): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
09-09 12:18:55.079-0500 W/W_HOME  ( 1143): main.c: home_resume(735) > clock/widget resumed
09-09 12:18:55.139-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
09-09 12:18:55.149-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:18:55.159-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:18:55.159-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:18:55.159-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:18:55.169-0500 E/RESOURCED(  935): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.solemntree.romannumeralwatch, table num : 1
09-09 12:18:55.169-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:18:55.179-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:18:55.179-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
09-09 12:18:55.179-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:18:55.199-0500 I/CAPI_WATCH_APPLICATION( 3652): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:18:55.289-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:18:55.289-0500 W/WATCH_CORE( 3653): appcore-watch.c: __widget_resume(1012) > widget_resume
09-09 12:18:55.289-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppResume(721) > 
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [4]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [4]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [4] to pending list
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [6]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [6]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [6] to pending list
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [13]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [13]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [13] to pending list
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [27]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [27]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [27] to pending list
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [1]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [1] to pending list
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [2]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [2] to pending list
09-09 12:18:55.289-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:18:55.289-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [3]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [3] to pending list
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [4]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [5]
09-09 12:18:55.289-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: AddPendingChanges(1088) > added [5] to pending list
09-09 12:18:55.329-0500 W/WATCH_CORE( 3652): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:18:55.329-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1992.561890] pkgname: org.solemntree.romannumeralwatch, id: file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1992.561890.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:18:55.329-0500 W/W_HOME  ( 1143): dbox.c: _widget_created_cb(244) > widget resume:0xac209718
09-09 12:18:55.329-0500 E/WIDGET_VIEWER( 1143): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
09-09 12:18:55.349-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
09-09 12:18:55.349-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
09-09 12:18:55.469-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:18:55.469-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:18:55.469-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [1]
09-09 12:18:55.469-0500 I/watchface-viewer( 3653): viewer-data-provider.cpp: NotifyListeners(637) > dummy mode!! ignored!! [2]
09-09 12:18:55.589-0500 W/CRASH_MANAGER( 3890): worker.c: worker_job(1199) > 1103652726f6d147344153
