﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: InternalsVisibleTo("SmtpServer.Tests")]
//[assembly: InternalsVisibleTo("SmtpServer.Tests,PublicKey=" +
//"0024000004800000940000000602000000240000525341310004000001000100e9268fca1f93be" +
//"b8bdd9d4299feca817e004b5d8f85a44c88f96cc66b131040d7b2a792118dad456a29fb0c2ba0a" +
//"11e008c9c5295ab9e917436ee4c63b2df5d30bf854243a6d90ae4575c14eed29074c3f13eca058" +
//"466e0f540a550693d97c654d4f65300659634dd8a8d61f427dfd56d74003dcd8504c25b22546ab" +
//"0837f1a7")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("00aedbfc-13a6-44ec-89e5-57b12f39372d")]
