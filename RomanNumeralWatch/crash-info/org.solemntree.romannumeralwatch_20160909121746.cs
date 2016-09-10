S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3609
Date: 2016-09-09 12:17:46-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x0000000c, r1   = 0x00000025
r2   = 0xbeda407c, r3   = 0x0000feff
r4   = 0x00000008, r5   = 0x0000000c
r6   = 0xbeda3b48, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xb5b344d0
r10  = 0x0000000c, fp   = 0xbeda3b3c
ip   = 0x0000000c, sp   = 0xbeda35c8
lr   = 0xb6a0af5c, pc   = 0xb6a456dc
cpsr = 0x60000010

Memory Information
MemTotal:   391348 KB
MemFree:     22900 KB
Buffers:      9000 KB
Cached:      89640 KB
VmPeak:      63556 KB
VmSize:      63012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13020 KB
VmRSS:       13020 KB
VmData:      11632 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3609 TID = 3609
3609 3641 

Maps Information
b34a8000 b34bf000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b34cc000 b3553000 rw-s anon_inode:dmabuf
b3553000 b355e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3567000 b3569000 r-xp /usr/lib/libgenlock.so
b357c000 b357f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b3588000 b3d87000 rwxp [stack:3641]
b3f87000 b3f8e000 r-xp /usr/lib/libtbm.so.1.0.0
b3f96000 b3f98000 r-xp /usr/lib/libdri2.so.0.0.0
b3fa0000 b3fa5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fad000 b3fb5000 r-xp /usr/lib/libdrm.so.2.4.0
b3fbd000 b3fc6000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3fcf000 b3fdb000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3fe3000 b3fec000 r-xp /usr/lib/libcom-core.so.0.0.1
b557c000 b5582000 r-xp /usr/lib/libwidget.so.1.0.0
b558b000 b5591000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b5599000 b567d000 r-xp /usr/lib/libicuuc.so.51.1
b5692000 b57cf000 r-xp /usr/lib/libicui18n.so.51.1
b57df000 b57ec000 r-xp /usr/lib/libalarm.so.0.0.0
b57f5000 b57fc000 r-xp /usr/lib/libappcore-watch.so.1.1
b59a4000 b59ae000 r-xp /lib/libnss_files-2.13.so
b59b7000 b5a86000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a9c000 b5ac0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5ac9000 b5acf000 r-xp /usr/lib/libappsvc.so.0.1.0
b5ad7000 b5ad9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5ae2000 b5ae6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5af8000 b5afd000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b05000 b5b07000 r-xp /usr/lib/libiniparser.so.0
b5b10000 b5b15000 r-xp /usr/lib/libappcore-common.so.1.1
b5b1d000 b5b1f000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b5b27000 b5b2b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b38000 b5b3a000 r-xp /usr/lib/libXau.so.6.0.0
b5b43000 b5b4a000 r-xp /lib/libcrypt-2.13.so
b5b7a000 b5b7c000 r-xp /usr/lib/libiri.so
b5b84000 b5d2c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d45000 b5d92000 r-xp /usr/lib/libssl.so.1.0.0
b5d9f000 b5dcd000 r-xp /usr/lib/libidn.so.11.5.44
b5dd5000 b5dde000 r-xp /usr/lib/libcares.so.2.1.0
b5de7000 b5dfa000 r-xp /usr/lib/libxcb.so.1.1.0
b5e03000 b5e05000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e0e000 b5e10000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e19000 b5ee5000 r-xp /usr/lib/libxml2.so.2.7.8
b5ef2000 b5ef4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5efc000 b5f01000 r-xp /usr/lib/libffi.so.5.0.10
b5f09000 b5f0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f13000 b5f1e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f26000 b5f29000 r-xp /lib/libattr.so.1.1.0
b5f31000 b5fc5000 r-xp /usr/lib/libstdc++.so.6.0.16
b5fd8000 b5ff5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5ffe000 b6016000 r-xp /usr/lib/libpng12.so.0.50.0
b601f000 b6035000 r-xp /lib/libexpat.so.1.5.2
b603f000 b6083000 r-xp /usr/lib/libcurl.so.4.3.0
b608c000 b6096000 r-xp /usr/lib/libXext.so.6.4.0
b609f000 b60a3000 r-xp /usr/lib/libXtst.so.6.1.0
b60ab000 b60b1000 r-xp /usr/lib/libXrender.so.1.3.0
b60ba000 b60c0000 r-xp /usr/lib/libXrandr.so.2.2.0
b60c8000 b60c9000 r-xp /usr/lib/libXinerama.so.1.0.0
b60d2000 b60db000 r-xp /usr/lib/libXi.so.6.1.0
b60e3000 b60e6000 r-xp /usr/lib/libXfixes.so.3.1.0
b60ee000 b60f0000 r-xp /usr/lib/libXgesture.so.7.0.0
b60f8000 b60fa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6103000 b6105000 r-xp /usr/lib/libXdamage.so.1.1.0
b610d000 b6114000 r-xp /usr/lib/libXcursor.so.1.0.2
b611c000 b611f000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6127000 b612b000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6134000 b6139000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6143000 b6224000 r-xp /usr/lib/libX11.so.6.3.0
b622f000 b6252000 r-xp /usr/lib/libjpeg.so.8.0.2
b626a000 b6280000 r-xp /lib/libz.so.1.2.5
b6288000 b62fd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6307000 b631d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6326000 b635a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6363000 b6436000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6441000 b6451000 r-xp /lib/libresolv-2.13.so
b6455000 b64d1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64dd000 b64f5000 r-xp /usr/lib/liblzma.so.5.0.3
b64fe000 b6501000 r-xp /lib/libcap.so.2.21
b6509000 b6536000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b653e000 b653f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6547000 b654d000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6555000 b656c000 r-xp /usr/lib/liblua-5.1.so
b6576000 b657d000 r-xp /usr/lib/libembryo.so.1.7.99
b6585000 b658b000 r-xp /lib/librt-2.13.so
b6594000 b65ea000 r-xp /usr/lib/libpixman-1.so.0.28.2
b65f7000 b664d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6659000 b6681000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6683000 b66c0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66c9000 b66dc000 r-xp /usr/lib/libfribidi.so.0.3.1
b66e4000 b66fe000 r-xp /usr/lib/libecore_con.so.1.7.99
b6707000 b6710000 r-xp /usr/lib/libedbus.so.1.7.99
b6718000 b6768000 r-xp /usr/lib/libecore_x.so.1.7.99
b676b000 b676f000 r-xp /usr/lib/libvconf.so.0.2.45
b6777000 b6788000 r-xp /usr/lib/libecore_input.so.1.7.99
b6790000 b6795000 r-xp /usr/lib/libecore_file.so.1.7.99
b679d000 b67bf000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67c8000 b6809000 r-xp /usr/lib/libeina.so.1.7.99
b6812000 b682b000 r-xp /usr/lib/libeet.so.1.7.99
b683c000 b68a5000 r-xp /lib/libm-2.13.so
b68ae000 b68b4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68bd000 b68c0000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68c8000 b68ea000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68f2000 b68f7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68ff000 b6929000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6932000 b6949000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6951000 b695c000 r-xp /lib/libunwind.so.8.0.1
b6989000 b69c5000 r-xp /usr/lib/libsystemd.so.0.4.0
b69ce000 b6ae9000 r-xp /lib/libc-2.13.so
b6af7000 b6aff000 r-xp /lib/libgcc_s-4.6.so.1
b6b00000 b6b03000 r-xp /usr/lib/libsmack.so.1.0.0
b6b0b000 b6b11000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b19000 b6be9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6bea000 b6c47000 r-xp /usr/lib/libedje.so.1.7.99
b6c51000 b6c68000 r-xp /usr/lib/libecore.so.1.7.99
b6c7f000 b6d4d000 r-xp /usr/lib/libevas.so.1.7.99
b6d72000 b6ead000 r-xp /usr/lib/libelementary.so.1.7.99
b6ec3000 b6ed7000 r-xp /lib/libpthread-2.13.so
b6ee2000 b6ee4000 r-xp /usr/lib/libdlog.so.0.0.0
b6eec000 b6eef000 r-xp /usr/lib/libbundle.so.0.1.22
b6ef7000 b6ef9000 r-xp /lib/libdl-2.13.so
b6f02000 b6f0e000 r-xp /usr/lib/libaul.so.0.1.0
b6f20000 b6f25000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2e000 b6f32000 r-xp /usr/lib/libsys-assert.so
b6f3b000 b6f58000 r-xp /lib/ld-2.13.so
b6f61000 b6f66000 r-xp /usr/bin/launchpad-loader
b7af6000 b7c4a000 rw-p [heap]
bed84000 beda5000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3609)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xb6a456dc) [/lib/libc.so.6] + 0x776dc
End of Call Stack

Latest Debug Message Information
--------- beginning of /dev/log_main
tIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
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
09-09 12:17:50.199-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103626726f6d1473441465
09-09 12:17:50.229-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:50.229-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:50.419-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:50.419-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:50.479-0500 I/watchface-viewer( 3653): viewer-part-resource-evas.cpp: ColonAnimationTimerExpired(1569) > 
09-09 12:17:50.609-0500 I/CAPI_WATCH_APPLICATION( 3653): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
09-09 12:17:50.609-0500 E/watchface-loader( 3653): watchface-loader.cpp: OnAppTimeTick(740) > 
09-09 12:17:50.709-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: recv - ConnID( 1 ), Res( -1 )
09-09 12:17:50.709-0500 E/SCSD    ( 1705): <recv_thread:183> sec_recv() ret: -1
09-09 12:17:50.709-0500 W/SNL_W   ( 1705): <sec_close_w:321> sec_close_w - sec_close_w begin()
09-09 12:17:50.709-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: close - Call ConnID( 1 ), Timeout ( 0 )
09-09 12:17:50.719-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: sc_dis connid( 1 ), way( 1)
09-09 12:17:50.719-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: sc_dis .
09-09 12:17:50.719-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: close - Res( 0 )
09-09 12:17:50.719-0500 W/SNL_W   ( 1705): <deleteConnIdData:205> ==== deleteConnIdData Start conn_id[1] ====
09-09 12:17:50.719-0500 W/SNL_W   ( 1705): <deleteConnIdData:218> deleteConnIdData timestamp( 1473441170 )
09-09 12:17:50.719-0500 W/SNL_W   ( 1705): <deleteConnIdData:233> ==== deleteConnIdData end res[0] ====
09-09 12:17:50.719-0500 W/SNL     ( 1705): Scone_Log.cpp: dump(2972) > SNL :: close - Res( -1 )
09-09 12:17:50.719-0500 W/SNL_W   ( 1705): <deleteConnIdData:205> ==== deleteConnIdData Start conn_id[1] ====
09-09 12:17:50.719-0500 W/SNL_W   ( 1705): <deleteConnIdData:233> ==== deleteConnIdData end res[0] ====
09-09 12:17:50.719-0500 W/SNL_W   ( 1705): <sec_close_w:325> sec_close_w - D2D close is Running -conn_id ( 1) deleted 
09-09 12:17:50.719-0500 W/SNL_W   ( 1705): <sec_close_w:328> sec_close_w - sec_close_w res( -1 )
09-09 12:17:50.719-0500 E/SCSD    ( 1705): <util_scs_close:1227> sec_close() failed. (ret:-1)
09-09 12:17:50.719-0500 E/SCSD    ( 1705): <util_scs_close:1231> message: Object Not Found
09-09 12:17:50.719-0500 W/SCSD    ( 1705): <_disconnected_cb:492> SCS Peer Disconnected !!!
09-09 12:17:50.719-0500 W/SCSD    ( 1705): <_disconnected_cb:493>  - conn_id: 1
09-09 12:17:50.719-0500 W/SCSD    ( 1705): <util_dbus_set_connection_status:263> same status(0)
09-09 12:17:50.719-0500 W/SCSD    ( 1705): <util_tel_set_ps_dormant:9> request GoDormantAll
09-09 12:17:50.729-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103609726f6d147344146
