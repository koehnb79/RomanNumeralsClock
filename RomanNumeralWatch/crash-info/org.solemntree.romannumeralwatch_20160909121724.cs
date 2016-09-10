S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: romannumeralwatch
PID: 3061
Date: 2016-09-09 12:17:24-0500
Executable File Path: /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x198

Register Information
r0   = 0x0000018c, r1   = 0x0000000d
r2   = 0x0000001c, r3   = 0xb5af2194
r4   = 0x0000018c, r5   = 0x00000000
r6   = 0xb84315f4, r7   = 0xb8423008
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0xb6f34dc0
ip   = 0xbed80cac, sp   = 0xbed80c60
lr   = 0xb6f1a0d0, pc   = 0xb6f199dc
cpsr = 0x20000010

Memory Information
MemTotal:   391348 KB
MemFree:     21800 KB
Buffers:      9364 KB
Cached:      96320 KB
VmPeak:     105644 KB
VmSize:     105100 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14988 KB
VmRSS:       14988 KB
VmData:      21304 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3061 TID = 3061
3061 3214 3220 

Maps Information
b0c3b000 b143a000 rwxp [stack:3220]
b347d000 b3494000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b34a1000 b3528000 rw-s anon_inode:dmabuf
b3528000 b3533000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b353c000 b353e000 r-xp /usr/lib/libgenlock.so
b3551000 b3554000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b355d000 b3d5c000 rwxp [stack:3214]
b3f5c000 b3f63000 r-xp /usr/lib/libtbm.so.1.0.0
b3f6b000 b3f6d000 r-xp /usr/lib/libdri2.so.0.0.0
b3f75000 b3f7a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f82000 b3f8a000 r-xp /usr/lib/libdrm.so.2.4.0
b3f92000 b3f9b000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3fa4000 b3fb0000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3fb8000 b3fc1000 r-xp /usr/lib/libcom-core.so.0.0.1
b5551000 b5557000 r-xp /usr/lib/libwidget.so.1.0.0
b5560000 b5566000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b556e000 b5652000 r-xp /usr/lib/libicuuc.so.51.1
b5667000 b57a4000 r-xp /usr/lib/libicui18n.so.51.1
b57b4000 b57c1000 r-xp /usr/lib/libalarm.so.0.0.0
b57ca000 b57d1000 r-xp /usr/lib/libappcore-watch.so.1.1
b5979000 b5983000 r-xp /lib/libnss_files-2.13.so
b598c000 b5a5b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a71000 b5a95000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5a9e000 b5aa4000 r-xp /usr/lib/libappsvc.so.0.1.0
b5aac000 b5aae000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5ab7000 b5abb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5acd000 b5ad2000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5ada000 b5adc000 r-xp /usr/lib/libiniparser.so.0
b5ae5000 b5aea000 r-xp /usr/lib/libappcore-common.so.1.1
b5af2000 b5af4000 r-xp /opt/usr/apps/org.solemntree.romannumeralwatch/bin/romannumeralwatch
b5afc000 b5b00000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b0d000 b5b0f000 r-xp /usr/lib/libXau.so.6.0.0
b5b18000 b5b1f000 r-xp /lib/libcrypt-2.13.so
b5b4f000 b5b51000 r-xp /usr/lib/libiri.so
b5b59000 b5d01000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d1a000 b5d67000 r-xp /usr/lib/libssl.so.1.0.0
b5d74000 b5da2000 r-xp /usr/lib/libidn.so.11.5.44
b5daa000 b5db3000 r-xp /usr/lib/libcares.so.2.1.0
b5dbc000 b5dcf000 r-xp /usr/lib/libxcb.so.1.1.0
b5dd8000 b5dda000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5de3000 b5de5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5dee000 b5eba000 r-xp /usr/lib/libxml2.so.2.7.8
b5ec7000 b5ec9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5ed1000 b5ed6000 r-xp /usr/lib/libffi.so.5.0.10
b5ede000 b5edf000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5ee8000 b5ef3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5efb000 b5efe000 r-xp /lib/libattr.so.1.1.0
b5f06000 b5f9a000 r-xp /usr/lib/libstdc++.so.6.0.16
b5fad000 b5fca000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5fd3000 b5feb000 r-xp /usr/lib/libpng12.so.0.50.0
b5ff4000 b600a000 r-xp /lib/libexpat.so.1.5.2
b6014000 b6058000 r-xp /usr/lib/libcurl.so.4.3.0
b6061000 b606b000 r-xp /usr/lib/libXext.so.6.4.0
b6074000 b6078000 r-xp /usr/lib/libXtst.so.6.1.0
b6080000 b6086000 r-xp /usr/lib/libXrender.so.1.3.0
b608f000 b6095000 r-xp /usr/lib/libXrandr.so.2.2.0
b609d000 b609e000 r-xp /usr/lib/libXinerama.so.1.0.0
b60a7000 b60b0000 r-xp /usr/lib/libXi.so.6.1.0
b60b8000 b60bb000 r-xp /usr/lib/libXfixes.so.3.1.0
b60c3000 b60c5000 r-xp /usr/lib/libXgesture.so.7.0.0
b60cd000 b60cf000 r-xp /usr/lib/libXcomposite.so.1.0.0
b60d8000 b60da000 r-xp /usr/lib/libXdamage.so.1.1.0
b60e2000 b60e9000 r-xp /usr/lib/libXcursor.so.1.0.2
b60f1000 b60f4000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60fc000 b6100000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6109000 b610e000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6118000 b61f9000 r-xp /usr/lib/libX11.so.6.3.0
b6204000 b6227000 r-xp /usr/lib/libjpeg.so.8.0.2
b623f000 b6255000 r-xp /lib/libz.so.1.2.5
b625d000 b62d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b62dc000 b62f2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b62fb000 b632f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6338000 b640b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6416000 b6426000 r-xp /lib/libresolv-2.13.so
b642a000 b64a6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64b2000 b64ca000 r-xp /usr/lib/liblzma.so.5.0.3
b64d3000 b64d6000 r-xp /lib/libcap.so.2.21
b64de000 b650b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6513000 b6514000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b651c000 b6522000 r-xp /usr/lib/libecore_imf.so.1.7.99
b652a000 b6541000 r-xp /usr/lib/liblua-5.1.so
b654b000 b6552000 r-xp /usr/lib/libembryo.so.1.7.99
b655a000 b6560000 r-xp /lib/librt-2.13.so
b6569000 b65bf000 r-xp /usr/lib/libpixman-1.so.0.28.2
b65cc000 b6622000 r-xp /usr/lib/libfreetype.so.6.11.3
b662e000 b6656000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6658000 b6695000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b669e000 b66b1000 r-xp /usr/lib/libfribidi.so.0.3.1
b66b9000 b66d3000 r-xp /usr/lib/libecore_con.so.1.7.99
b66dc000 b66e5000 r-xp /usr/lib/libedbus.so.1.7.99
b66ed000 b673d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6740000 b6744000 r-xp /usr/lib/libvconf.so.0.2.45
b674c000 b675d000 r-xp /usr/lib/libecore_input.so.1.7.99
b6765000 b676a000 r-xp /usr/lib/libecore_file.so.1.7.99
b6772000 b6794000 r-xp /usr/lib/libecore_evas.so.1.7.99
b679d000 b67de000 r-xp /usr/lib/libeina.so.1.7.99
b67e7000 b6800000 r-xp /usr/lib/libeet.so.1.7.99
b6811000 b687a000 r-xp /lib/libm-2.13.so
b6883000 b6889000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6892000 b6895000 r-xp /usr/lib/libproc-stat.so.0.2.86
b689d000 b68bf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68c7000 b68cc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68d4000 b68fe000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6907000 b691e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6926000 b6931000 r-xp /lib/libunwind.so.8.0.1
b695e000 b699a000 r-xp /usr/lib/libsystemd.so.0.4.0
b69a3000 b6abe000 r-xp /lib/libc-2.13.so
b6acc000 b6ad4000 r-xp /lib/libgcc_s-4.6.so.1
b6ad5000 b6ad8000 r-xp /usr/lib/libsmack.so.1.0.0
b6ae0000 b6ae6000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6aee000 b6bbe000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6bbf000 b6c1c000 r-xp /usr/lib/libedje.so.1.7.99
b6c26000 b6c3d000 r-xp /usr/lib/libecore.so.1.7.99
b6c54000 b6d22000 r-xp /usr/lib/libevas.so.1.7.99
b6d47000 b6e82000 r-xp /usr/lib/libelementary.so.1.7.99
b6e98000 b6eac000 r-xp /lib/libpthread-2.13.so
b6eb7000 b6eb9000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec1000 b6ec4000 r-xp /usr/lib/libbundle.so.0.1.22
b6ecc000 b6ece000 r-xp /lib/libdl-2.13.so
b6ed7000 b6ee3000 r-xp /usr/lib/libaul.so.0.1.0
b6ef5000 b6efa000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f03000 b6f07000 r-xp /usr/lib/libsys-assert.so
b6f10000 b6f2d000 r-xp /lib/ld-2.13.so
b6f36000 b6f3b000 r-xp /usr/bin/launchpad-loader
b8331000 b84f1000 rw-p [heap]
bed61000 bed82000 rwxp [stack]
bed61000 bed82000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3061)
Call Stack Count: 6
 0: (0xb6f199dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0xb6f1a0d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0xb6f1a360) [/lib/ld-linux.so.3] + 0xa360
 3: (0xb6f1e5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0xb6f24a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0xb6a1070c) [/lib/libc.so.6] + 0x6d70c
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
tIpcServer::HandleReceivedMessage
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:02.479-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:02.489-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.489-0500 E/CAPI_APPFW_APP_CONTROL( 1261): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
09-09 12:17:02.489-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1261]   [com.samsung.w-home]register msg port [true][0m
09-09 12:17:02.489-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:02.489-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1143
09-09 12:17:02.499-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1261]   [MUSIC_PLAYER_EVENT][0m
09-09 12:17:02.499-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:17:02.499-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:17:02.499-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: preference_get_int(1132) > preference_get_int(1261) : key(music-control-service_native/playing_diration) error
09-09 12:17:02.499-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1261]   preference_get_int() .. [0xfef00030][0m
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:02.499-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.499-0500 W/W_HOME  ( 1143): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:17:02.499-0500 E/W_HOME  ( 1143): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:17:02.499-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1261]   [MUSIC_PLAYER_EVENT][0m
09-09 12:17:02.499-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:17:02.499-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:17:02.509-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1261): preference.c: preference_get_int(1132) > preference_get_int(1261) : key(music-control-service_native/playing_diration) error
09-09 12:17:02.509-0500 W/MUSIC_CONTROL_SERVICE( 1261): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1261]   preference_get_int() .. [0xfef00030][0m
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.509-0500 W/W_HOME  ( 1143): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:17:02.509-0500 E/W_HOME  ( 1143): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:17:02.509-0500 I/TIZEN_N_SOUND_MANAGER( 1261): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
09-09 12:17:02.509-0500 W/TIZEN_N_SOUND_MANAGER( 1261): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:17:02.509-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:17:02.559-0500 E/PKGMGR_SERVER( 3195): pkgmgr-server.c: req_cb(650) > req_id=[org.solemntree.romannumeralwatch_1351875706], req_type=[12], pkg_type=[rpm], pkgid=[org.solemntree.romannumeralwatch], args=[], cookie=[M0l4UcAassq3mqyxlq7YFr8B0K8=], backend_flag=[0]
09-09 12:17:02.559-0500 E/PKGMGR_SERVER( 3197): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.solemntree.romannumeralwatch]
09-09 12:17:02.609-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:02.619-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2956
09-09 12:17:02.619-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 12
09-09 12:17:02.619-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 5
09-09 12:17:04.519-0500 E/PKGMGR_SERVER( 3195): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:17:06.519-0500 E/PKGMGR_SERVER( 3195): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
09-09 12:17:07.409-0500 I/GESTURE (  252): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
09-09 12:17:07.629-0500 E/AUL_AMD (  934): amd_launch.c: __recv_timeout_handler(941) > application is not responding : pid(2956) cmd(4)
09-09 12:17:07.649-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
09-09 12:17:07.679-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
09-09 12:17:07.689-0500 E/PKGMGR_SERVER( 3197): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
09-09 12:17:07.739-0500 E/PKGMGR  ( 3192): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.solemntree.romannumeralwatch, -1]
09-09 12:17:07.749-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 4
09-09 12:17:07.749-0500 E/AUL     (  934): app_sock.c: __connect_client_sock(196) > connect error: 111
09-09 12:17:07.749-0500 E/AUL     (  934): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-09 12:17:07.839-0500 E/PKGMGR_SERVER( 3195): pkgmgr-server.c: sighandler(409) > child NORMAL exit [3197]
09-09 12:17:07.849-0500 E/AUL     (  934): app_sock.c: __connect_client_sock(196) > connect error: 111
09-09 12:17:07.849-0500 E/AUL     (  934): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-09 12:17:07.969-0500 W/W_HOME  ( 1143): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
09-09 12:17:08.159-0500 E/AUL     (  934): app_sock.c: __connect_client_sock(196) > connect error: 111
09-09 12:17:08.159-0500 E/AUL     (  934): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-09 12:17:08.159-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
09-09 12:17:08.179-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:08.209-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-09 12:17:08.209-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
09-09 12:17:08.209-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 1097
09-09 12:17:08.249-0500 E/RESOURCED(  935): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.solemntree.romannumeralwatch, table num : 1
09-09 12:17:08.249-0500 E/RESOURCED(  935): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
09-09 12:17:08.259-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(2086) > pad pid(-5)
09-09 12:17:08.259-0500 W/AUL_PAD ( 1681): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
09-09 12:17:08.259-0500 W/AUL_PAD ( 1681): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:17:08.299-0500 I/CAPI_WATCH_APPLICATION( 3061): watch_app_main.c: watch_app_main(382) > watch_app_main
09-09 12:17:08.369-0500 E/AUL     (  934): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
09-09 12:17:08.399-0500 W/WATCH_CORE( 3061): appcore-watch.c: __widget_create(958) > widget_create
09-09 12:17:08.399-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1712) > [SECURE_LOG] [1573.991821] pkgname: org.solemntree.romannumeralwatch, id: file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1573.991821.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://23068706:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
09-09 12:17:08.399-0500 E/WIDGET_VIEWER( 1143): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[1573.991821] pkgname[org.solemntree.romannumeralwatch], id[file:///opt/usr/share/live_magazine/org.solemntree.romannumeralwatch_1143_1573.991821.png] content[] cluster[user,created] category[default] widget_fname[pixmap://23068706:4] gbar_fname[]
09-09 12:17:08.429-0500 E/WIDGET_VIEWER( 1143): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
09-09 12:17:08.429-0500 E/WIDGET_EVAS( 1143): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
09-09 12:17:08.489-0500 E/EFL     ( 3061): <3061> eina_hash.c:922 eina_hash_add() safety check failed: data == NULL
09-09 12:17:08.499-0500 W/WATCH_CORE( 3061): appcore-watch.c: __widget_create(976) > widget_create done
09-09 12:17:08.519-0500 E/PKGMGR_SERVER( 3195): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
09-09 12:17:08.519-0500 E/PKGMGR_SERVER( 3195): pkgmgr-server.c: main(2185) > package manager server terminated.
09-09 12:17:08.599-0500 I/WATCH_CORE( 3061): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
09-09 12:17:08.599-0500 I/WATCH_CORE( 3061): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
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
09-09 12:17:24.889-0500 W/CRASH_MANAGER( 3334): worker.c: worker_job(1199) > 1103061726f6d147344144
