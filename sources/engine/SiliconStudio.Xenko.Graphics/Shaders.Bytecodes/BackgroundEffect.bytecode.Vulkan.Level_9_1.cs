﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_VULKAN
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [BackgroundEffect]
//
//     Command Line: C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-Vulkan --platform=Windows --output-path=C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    internal partial class BackgroundEffect
    {
        private static readonly byte[] binaryBytecode = new byte[] {
4, 192, 254, 239, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 1, 5, 0, 0, 0, 255, 255, 
255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 7, 
80, 101, 114, 68, 114, 97, 119, 10, 0, 0, 0, 26, 0, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 0, 7, 80, 101, 114, 68, 114, 97, 119, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 26, 0, 0, 0, 0, 
7, 71, 108, 111, 98, 97, 108, 115, 0, 7, 71, 108, 111, 98, 97, 108, 115, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 64, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 3, 0, 
0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 26, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 
109, 95, 105, 100, 55, 50, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 84, 0, 0, 0, 1, 0, 0, 0, 0, 11, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 
1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 52, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 
1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 
49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 54, 8, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 
101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 56, 16, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 
0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 
48, 24, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 
122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 50, 32, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 
84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 52, 40, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 
0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 
120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 54, 48, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 
117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 56, 56, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 
0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 48, 64, 0, 
0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 
22, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 50, 72, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 26, 66, 97, 99, 
107, 103, 114, 111, 117, 110, 100, 69, 102, 102, 101, 99, 116, 46, 73, 110, 116, 101, 110, 115, 105, 116, 121, 0, 14, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 51, 80, 0, 0, 0, 4, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 
16, 66, 97, 99, 107, 103, 114, 111, 117, 110, 100, 69, 102, 102, 101, 99, 116, 1, 139, 240, 166, 191, 210, 146, 200, 37, 253, 222, 253, 77, 90, 154, 228, 178, 10, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 1, 164, 17, 184, 245, 17, 45, 155, 200, 33, 38, 142, 140, 129, 225, 169, 76, 10, 83, 
104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 92, 49, 96, 204, 191, 147, 108, 94, 16, 43, 217, 49, 95, 15, 148, 106, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 246, 153, 8, 5, 148, 172, 99, 193, 243, 129, 64, 222, 87, 206, 26, 123, 9, 84, 101, 120, 
116, 117, 114, 105, 110, 103, 1, 169, 217, 238, 31, 185, 166, 138, 247, 206, 107, 18, 41, 22, 134, 250, 234, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 90, 178, 177, 153, 229, 215, 138, 9, 233, 205, 31, 227, 9, 216, 120, 170, 0, 152, 9, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 
0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 1, 0, 0, 0, 0, 9, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 1, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 4, 0, 0, 0, 0, 96, 9, 0, 0, 3, 2, 35, 7, 0, 0, 1, 0, 1, 0, 8, 0, 77, 0, 0, 0, 0, 
0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 17, 0, 2, 0, 32, 0, 0, 0, 17, 0, 2, 0, 33, 0, 0, 0, 11, 0, 6, 0, 1, 0, 0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 53, 48, 0, 0, 0, 0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 15, 
0, 9, 0, 0, 0, 0, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 15, 0, 0, 0, 21, 0, 0, 0, 60, 0, 0, 0, 66, 0, 0, 0, 3, 0, 3, 0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 
0, 5, 0, 9, 0, 0, 0, 86, 83, 95, 73, 78, 80, 85, 84, 0, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 0, 0, 0, 0, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 1, 0, 0, 0, 84, 101, 120, 67, 111, 
111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 5, 0, 5, 0, 11, 0, 0, 0, 95, 48, 105, 110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 5, 0, 15, 0, 0, 0, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 5, 0, 21, 0, 0, 0, 97, 95, 80, 79, 83, 
73, 84, 73, 79, 78, 48, 0, 5, 0, 5, 0, 25, 0, 0, 0, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 25, 0, 0, 0, 0, 0, 0, 0, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 0, 0, 0, 6, 0, 7, 0, 25, 0, 0, 0, 1, 
0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 8, 0, 25, 0, 0, 0, 2, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 5, 0, 4, 0, 27, 0, 0, 0, 115, 116, 114, 101, 97, 
109, 115, 0, 5, 0, 4, 0, 38, 0, 0, 0, 80, 101, 114, 68, 114, 97, 119, 0, 6, 0, 9, 0, 38, 0, 0, 0, 0, 0, 0, 0, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 0, 0, 0, 0, 5, 0, 3, 0, 40, 0, 0, 0, 0, 
0, 0, 0, 5, 0, 5, 0, 46, 0, 0, 0, 86, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 8, 0, 46, 0, 0, 0, 0, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 7, 0, 46, 0, 0, 0, 1, 
0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 5, 0, 5, 0, 48, 0, 0, 0, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 6, 0, 58, 0, 0, 0, 103, 108, 95, 80, 101, 114, 86, 101, 114, 116, 101, 120, 0, 0, 0, 0, 6, 
0, 6, 0, 58, 0, 0, 0, 0, 0, 0, 0, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 6, 0, 7, 0, 58, 0, 0, 0, 1, 0, 0, 0, 103, 108, 95, 80, 111, 105, 110, 116, 83, 105, 122, 101, 0, 0, 0, 0, 6, 0, 7, 0, 58, 0, 0, 0, 2, 0, 0, 0, 103, 
108, 95, 67, 108, 105, 112, 68, 105, 115, 116, 97, 110, 99, 101, 0, 6, 0, 7, 0, 58, 0, 0, 0, 3, 0, 0, 0, 103, 108, 95, 67, 117, 108, 108, 68, 105, 115, 116, 97, 110, 99, 101, 0, 5, 0, 3, 0, 60, 0, 0, 0, 0, 0, 0, 0, 5, 0, 5, 0, 66, 0, 0, 0, 118, 
95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 5, 0, 76, 0, 0, 0, 78, 111, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 71, 0, 4, 0, 15, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 21, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 72, 
0, 4, 0, 38, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 72, 0, 5, 0, 38, 0, 0, 0, 0, 0, 0, 0, 35, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 38, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 16, 0, 0, 0, 71, 0, 3, 0, 38, 0, 0, 0, 2, 
0, 0, 0, 71, 0, 4, 0, 40, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 40, 0, 0, 0, 33, 0, 0, 0, 4, 0, 0, 0, 72, 0, 5, 0, 58, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 58, 0, 0, 0, 1, 
0, 0, 0, 11, 0, 0, 0, 1, 0, 0, 0, 72, 0, 5, 0, 58, 0, 0, 0, 2, 0, 0, 0, 11, 0, 0, 0, 3, 0, 0, 0, 72, 0, 5, 0, 58, 0, 0, 0, 3, 0, 0, 0, 11, 0, 0, 0, 4, 0, 0, 0, 71, 0, 3, 0, 58, 0, 0, 0, 2, 0, 0, 0, 71, 
0, 4, 0, 66, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 76, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 19, 0, 2, 0, 2, 0, 0, 0, 33, 0, 3, 0, 3, 0, 0, 0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 0, 32, 0, 0, 0, 23, 
0, 4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 23, 0, 4, 0, 8, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 30, 0, 4, 0, 9, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 10, 0, 0, 0, 7, 0, 0, 0, 9, 0, 0, 0, 21, 
0, 4, 0, 12, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 13, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 14, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 14, 0, 0, 0, 15, 0, 0, 0, 1, 0, 0, 0, 32, 
0, 4, 0, 17, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 19, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 20, 0, 0, 0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 20, 0, 0, 0, 21, 0, 0, 0, 1, 0, 0, 0, 32, 
0, 4, 0, 23, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 30, 0, 5, 0, 25, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 26, 0, 0, 0, 7, 0, 0, 0, 25, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 34, 0, 0, 0, 2, 
0, 0, 0, 24, 0, 4, 0, 37, 0, 0, 0, 7, 0, 0, 0, 4, 0, 0, 0, 30, 0, 3, 0, 38, 0, 0, 0, 37, 0, 0, 0, 32, 0, 4, 0, 39, 0, 0, 0, 2, 0, 0, 0, 38, 0, 0, 0, 59, 0, 4, 0, 39, 0, 0, 0, 40, 0, 0, 0, 2, 0, 0, 0, 32, 
0, 4, 0, 41, 0, 0, 0, 2, 0, 0, 0, 37, 0, 0, 0, 30, 0, 4, 0, 46, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 47, 0, 0, 0, 7, 0, 0, 0, 46, 0, 0, 0, 21, 0, 4, 0, 55, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 43, 
0, 4, 0, 55, 0, 0, 0, 56, 0, 0, 0, 1, 0, 0, 0, 28, 0, 4, 0, 57, 0, 0, 0, 6, 0, 0, 0, 56, 0, 0, 0, 30, 0, 6, 0, 58, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 57, 0, 0, 0, 57, 0, 0, 0, 32, 0, 4, 0, 59, 0, 0, 0, 3, 
0, 0, 0, 58, 0, 0, 0, 59, 0, 4, 0, 59, 0, 0, 0, 60, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 63, 0, 0, 0, 3, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 65, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 65, 0, 0, 0, 66, 
0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 69, 0, 0, 0, 3, 0, 0, 0, 6, 0, 0, 0, 26, 0, 2, 0, 74, 0, 0, 0, 32, 0, 4, 0, 75, 0, 0, 0, 0, 0, 0, 0, 74, 0, 0, 0, 59, 0, 4, 0, 75, 0, 0, 0, 76, 0, 0, 0, 0, 0, 0, 0, 54, 
0, 5, 0, 2, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 11, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 26, 0, 0, 0, 27, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 47, 
0, 0, 0, 48, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 16, 0, 0, 0, 15, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 18, 0, 0, 0, 11, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 18, 0, 0, 0, 16, 0, 0, 0, 61, 0, 4, 0, 7, 
0, 0, 0, 22, 0, 0, 0, 21, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 24, 0, 0, 0, 11, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 24, 0, 0, 0, 22, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 28, 0, 0, 0, 11, 0, 0, 0, 19, 0, 0, 0, 61, 
0, 4, 0, 7, 0, 0, 0, 29, 0, 0, 0, 28, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 30, 0, 0, 0, 27, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 30, 0, 0, 0, 29, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 31, 0, 0, 0, 11, 0, 0, 0, 13, 
0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 32, 0, 0, 0, 31, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 33, 0, 0, 0, 27, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 33, 0, 0, 0, 32, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 35, 0, 0, 0, 27, 
0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 36, 0, 0, 0, 35, 0, 0, 0, 65, 0, 5, 0, 41, 0, 0, 0, 42, 0, 0, 0, 40, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 37, 0, 0, 0, 43, 0, 0, 0, 42, 0, 0, 0, 144, 0, 5, 0, 7, 
0, 0, 0, 44, 0, 0, 0, 36, 0, 0, 0, 43, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 45, 0, 0, 0, 27, 0, 0, 0, 34, 0, 0, 0, 62, 0, 3, 0, 45, 0, 0, 0, 44, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 49, 0, 0, 0, 27, 0, 0, 0, 34, 
0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 50, 0, 0, 0, 49, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 51, 0, 0, 0, 48, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 51, 0, 0, 0, 50, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 52, 0, 0, 0, 27, 
0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 53, 0, 0, 0, 52, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 54, 0, 0, 0, 48, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 54, 0, 0, 0, 53, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 61, 
0, 0, 0, 48, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 62, 0, 0, 0, 61, 0, 0, 0, 65, 0, 5, 0, 63, 0, 0, 0, 64, 0, 0, 0, 60, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 64, 0, 0, 0, 62, 0, 0, 0, 65, 0, 5, 0, 17, 
0, 0, 0, 67, 0, 0, 0, 48, 0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 68, 0, 0, 0, 67, 0, 0, 0, 62, 0, 3, 0, 66, 0, 0, 0, 68, 0, 0, 0, 65, 0, 6, 0, 69, 0, 0, 0, 70, 0, 0, 0, 60, 0, 0, 0, 19, 0, 0, 0, 56, 
0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 71, 0, 0, 0, 70, 0, 0, 0, 127, 0, 4, 0, 6, 0, 0, 0, 72, 0, 0, 0, 71, 0, 0, 0, 65, 0, 6, 0, 69, 0, 0, 0, 73, 0, 0, 0, 60, 0, 0, 0, 19, 0, 0, 0, 56, 0, 0, 0, 62, 0, 3, 0, 73, 
0, 0, 0, 72, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 0, 5, 0, 0, 0, 1, 147, 184, 217, 107, 34, 56, 12, 1, 125, 39, 61, 179, 124, 212, 97, 215, 0, 220, 11, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 1, 0, 0, 0, 
18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 2, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 3, 0, 0, 0, 0, 148, 11, 0, 0, 3, 2, 35, 7, 0, 0, 1, 0, 1, 0, 8, 0, 83, 0, 
0, 0, 0, 0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 11, 0, 6, 0, 1, 0, 0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 53, 48, 0, 0, 0, 0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 15, 0, 8, 0, 4, 0, 0, 0, 4, 0, 0, 0, 109, 97, 
105, 110, 0, 0, 0, 0, 55, 0, 0, 0, 59, 0, 0, 0, 79, 0, 0, 0, 16, 0, 3, 0, 4, 0, 0, 0, 7, 0, 0, 0, 3, 0, 3, 0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 0, 5, 0, 9, 0, 
0, 0, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 0, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 
116, 95, 105, 100, 49, 0, 5, 0, 12, 0, 13, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 117, 99, 116, 45, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 45, 118, 102, 50, 45, 118, 102, 52, 49, 59, 0, 5, 0, 4, 0, 12, 0, 0, 0, 115, 116, 
114, 101, 97, 109, 115, 0, 5, 0, 12, 0, 16, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 51, 40, 115, 116, 114, 117, 99, 116, 45, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 45, 118, 102, 50, 45, 118, 102, 52, 49, 59, 0, 5, 0, 4, 0, 15, 0, 0, 0, 115, 116, 
114, 101, 97, 109, 115, 0, 5, 0, 6, 0, 20, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 0, 0, 0, 5, 0, 6, 0, 24, 0, 0, 0, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 0, 0, 0, 0, 5, 0, 4, 0, 36, 0, 0, 0, 71, 108, 
111, 98, 97, 108, 115, 0, 6, 0, 9, 0, 36, 0, 0, 0, 0, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 52, 0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 1, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 
120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 54, 0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 2, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 56, 0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 3, 0, 0, 0, 84, 101, 
120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 48, 0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 4, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 50, 0, 0, 6, 0, 9, 0, 36, 0, 
0, 0, 5, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 52, 0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 6, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 54, 
0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 7, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 56, 0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 8, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 
105, 122, 101, 95, 105, 100, 51, 48, 0, 0, 6, 0, 9, 0, 36, 0, 0, 0, 9, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 50, 0, 0, 6, 0, 7, 0, 36, 0, 0, 0, 10, 0, 0, 0, 73, 110, 116, 101, 110, 115, 
105, 116, 121, 95, 105, 100, 55, 51, 0, 0, 5, 0, 3, 0, 38, 0, 0, 0, 0, 0, 0, 0, 5, 0, 4, 0, 43, 0, 0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 5, 0, 5, 0, 50, 0, 0, 0, 86, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 8, 0, 50, 0, 
0, 0, 0, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 7, 0, 50, 0, 0, 0, 1, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 5, 0, 5, 0, 52, 0, 0, 0, 95, 48, 
105, 110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 5, 0, 55, 0, 0, 0, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 6, 0, 59, 0, 0, 0, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 0, 0, 0, 0, 5, 0, 4, 0, 63, 0, 0, 0, 115, 116, 
114, 101, 97, 109, 115, 0, 5, 0, 4, 0, 67, 0, 0, 0, 112, 97, 114, 97, 109, 0, 0, 0, 5, 0, 5, 0, 72, 0, 0, 0, 80, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 7, 0, 72, 0, 0, 0, 0, 0, 0, 0, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 
116, 95, 105, 100, 49, 0, 5, 0, 5, 0, 74, 0, 0, 0, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 10, 0, 79, 0, 0, 0, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 
49, 0, 5, 0, 5, 0, 82, 0, 0, 0, 78, 111, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 71, 0, 4, 0, 20, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 20, 0, 0, 0, 33, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 24, 0, 0, 0, 34, 0, 
0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 24, 0, 0, 0, 33, 0, 0, 0, 3, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 0, 0, 0, 0, 35, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 1, 0, 0, 0, 35, 0, 0, 0, 8, 0, 0, 0, 72, 0, 
5, 0, 36, 0, 0, 0, 2, 0, 0, 0, 35, 0, 0, 0, 16, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 3, 0, 0, 0, 35, 0, 0, 0, 24, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 4, 0, 0, 0, 35, 0, 0, 0, 32, 0, 0, 0, 72, 0, 5, 0, 36, 0, 
0, 0, 5, 0, 0, 0, 35, 0, 0, 0, 40, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 6, 0, 0, 0, 35, 0, 0, 0, 48, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 7, 0, 0, 0, 35, 0, 0, 0, 56, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 8, 0, 
0, 0, 35, 0, 0, 0, 64, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 9, 0, 0, 0, 35, 0, 0, 0, 72, 0, 0, 0, 72, 0, 5, 0, 36, 0, 0, 0, 10, 0, 0, 0, 35, 0, 0, 0, 80, 0, 0, 0, 71, 0, 3, 0, 36, 0, 0, 0, 2, 0, 0, 0, 71, 0, 
4, 0, 38, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 38, 0, 0, 0, 33, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 55, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 59, 0, 0, 0, 11, 0, 0, 0, 15, 0, 0, 0, 71, 0, 
4, 0, 79, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 82, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 19, 0, 2, 0, 2, 0, 0, 0, 33, 0, 3, 0, 3, 0, 0, 0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 0, 32, 0, 0, 0, 23, 0, 
4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 23, 0, 4, 0, 8, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 30, 0, 4, 0, 9, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 10, 0, 0, 0, 7, 0, 0, 0, 9, 0, 0, 0, 33, 0, 
4, 0, 11, 0, 0, 0, 8, 0, 0, 0, 10, 0, 0, 0, 25, 0, 9, 0, 18, 0, 0, 0, 6, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 19, 0, 0, 0, 0, 0, 0, 0, 18, 0, 
0, 0, 59, 0, 4, 0, 19, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, 26, 0, 2, 0, 22, 0, 0, 0, 32, 0, 4, 0, 23, 0, 0, 0, 0, 0, 0, 0, 22, 0, 0, 0, 59, 0, 4, 0, 23, 0, 0, 0, 24, 0, 0, 0, 0, 0, 0, 0, 27, 0, 3, 0, 26, 0, 
0, 0, 18, 0, 0, 0, 21, 0, 4, 0, 28, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 28, 0, 0, 0, 29, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 30, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 30, 0, 13, 0, 36, 0, 0, 0, 7, 0, 
0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 32, 0, 4, 0, 37, 0, 0, 0, 2, 0, 0, 0, 36, 0, 0, 0, 59, 0, 4, 0, 37, 0, 
0, 0, 38, 0, 0, 0, 2, 0, 0, 0, 43, 0, 4, 0, 28, 0, 0, 0, 39, 0, 0, 0, 10, 0, 0, 0, 32, 0, 4, 0, 40, 0, 0, 0, 2, 0, 0, 0, 6, 0, 0, 0, 30, 0, 4, 0, 50, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 51, 0, 
0, 0, 7, 0, 0, 0, 50, 0, 0, 0, 43, 0, 4, 0, 28, 0, 0, 0, 53, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 54, 0, 0, 0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 54, 0, 0, 0, 55, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 58, 0, 
0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 58, 0, 0, 0, 59, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 61, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 30, 0, 3, 0, 72, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 73, 0, 0, 0, 7, 0, 
0, 0, 72, 0, 0, 0, 32, 0, 4, 0, 78, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 78, 0, 0, 0, 79, 0, 0, 0, 3, 0, 0, 0, 59, 0, 4, 0, 23, 0, 0, 0, 82, 0, 0, 0, 0, 0, 0, 0, 54, 0, 5, 0, 2, 0, 0, 0, 4, 0, 
0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 4, 0, 51, 0, 0, 0, 52, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 63, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 67, 0, 0, 0, 7, 0, 
0, 0, 59, 0, 4, 0, 73, 0, 0, 0, 74, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 56, 0, 0, 0, 55, 0, 0, 0, 65, 0, 5, 0, 30, 0, 0, 0, 57, 0, 0, 0, 52, 0, 0, 0, 53, 0, 0, 0, 62, 0, 3, 0, 57, 0, 0, 0, 56, 0, 
0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 60, 0, 0, 0, 59, 0, 0, 0, 65, 0, 5, 0, 61, 0, 0, 0, 62, 0, 0, 0, 52, 0, 0, 0, 29, 0, 0, 0, 62, 0, 3, 0, 62, 0, 0, 0, 60, 0, 0, 0, 65, 0, 5, 0, 30, 0, 0, 0, 64, 0, 0, 0, 52, 0, 
0, 0, 53, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 65, 0, 0, 0, 64, 0, 0, 0, 65, 0, 5, 0, 30, 0, 0, 0, 66, 0, 0, 0, 63, 0, 0, 0, 29, 0, 0, 0, 62, 0, 3, 0, 66, 0, 0, 0, 65, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 68, 0, 
0, 0, 63, 0, 0, 0, 62, 0, 3, 0, 67, 0, 0, 0, 68, 0, 0, 0, 57, 0, 5, 0, 8, 0, 0, 0, 69, 0, 0, 0, 16, 0, 0, 0, 67, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 70, 0, 0, 0, 67, 0, 0, 0, 62, 0, 3, 0, 63, 0, 0, 0, 70, 0, 
0, 0, 65, 0, 5, 0, 61, 0, 0, 0, 71, 0, 0, 0, 63, 0, 0, 0, 53, 0, 0, 0, 62, 0, 3, 0, 71, 0, 0, 0, 69, 0, 0, 0, 65, 0, 5, 0, 61, 0, 0, 0, 75, 0, 0, 0, 63, 0, 0, 0, 53, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 76, 0, 
0, 0, 75, 0, 0, 0, 65, 0, 5, 0, 61, 0, 0, 0, 77, 0, 0, 0, 74, 0, 0, 0, 29, 0, 0, 0, 62, 0, 3, 0, 77, 0, 0, 0, 76, 0, 0, 0, 65, 0, 5, 0, 61, 0, 0, 0, 80, 0, 0, 0, 74, 0, 0, 0, 29, 0, 0, 0, 61, 0, 4, 0, 8, 0, 
0, 0, 81, 0, 0, 0, 80, 0, 0, 0, 62, 0, 3, 0, 79, 0, 0, 0, 81, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 54, 0, 5, 0, 8, 0, 0, 0, 13, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 0, 55, 0, 3, 0, 10, 0, 0, 0, 12, 0, 0, 0, 248, 0, 
2, 0, 14, 0, 0, 0, 61, 0, 4, 0, 18, 0, 0, 0, 21, 0, 0, 0, 20, 0, 0, 0, 61, 0, 4, 0, 22, 0, 0, 0, 25, 0, 0, 0, 24, 0, 0, 0, 86, 0, 5, 0, 26, 0, 0, 0, 27, 0, 0, 0, 21, 0, 0, 0, 25, 0, 0, 0, 65, 0, 5, 0, 30, 0, 
0, 0, 31, 0, 0, 0, 12, 0, 0, 0, 29, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 32, 0, 0, 0, 31, 0, 0, 0, 87, 0, 5, 0, 8, 0, 0, 0, 33, 0, 0, 0, 27, 0, 0, 0, 32, 0, 0, 0, 254, 0, 2, 0, 33, 0, 0, 0, 56, 0, 1, 0, 54, 0, 
5, 0, 8, 0, 0, 0, 16, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 0, 55, 0, 3, 0, 10, 0, 0, 0, 15, 0, 0, 0, 248, 0, 2, 0, 17, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 43, 0, 0, 0, 7, 0, 0, 0, 65, 0, 5, 0, 40, 0, 0, 0, 41, 0, 
0, 0, 38, 0, 0, 0, 39, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 42, 0, 0, 0, 41, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 44, 0, 0, 0, 15, 0, 0, 0, 62, 0, 3, 0, 43, 0, 0, 0, 44, 0, 0, 0, 57, 0, 5, 0, 8, 0, 0, 0, 45, 0, 
0, 0, 13, 0, 0, 0, 43, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 46, 0, 0, 0, 43, 0, 0, 0, 62, 0, 3, 0, 15, 0, 0, 0, 46, 0, 0, 0, 142, 0, 5, 0, 8, 0, 0, 0, 47, 0, 0, 0, 45, 0, 0, 0, 42, 0, 0, 0, 254, 0, 2, 0, 47, 0, 
0, 0, 56, 0, 1, 0, 
        };
    }
}
#endif
