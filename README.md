# SystemLock
Lock Windows from a Console App. Yeah, it's that simple...

# DllImportAttribute(String) Constructor

Namespace: [System.Runtime.InteropServices](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices?view=net-5.0)

Assemblies:mscorlib.dll, System.Runtime.InteropServices.dll

Initializes a new instance of the [DllImportAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-5.0) class with the name of the DLL containing the method to import.

## Parameters

```dllName``` String

The name of the DLL that contains the unmanaged method. This can include an assembly display name, if the DLL is included in an assembly.

## Examples

The following code example shows how to use the [DllImportAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-5.0) attribute to import the Win32 MessageBox function. The code example then calls the imported method.

```c#
using System;
using System.Runtime.InteropServices;

class Example
{
    // Use DllImport to import the Win32 MessageBox function.
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
    
    static void Main()
    {
        // Call the MessageBox function using platform invoke.
        MessageBox(new IntPtr(0), "Hello World!", "Hello Dialog", 0);
    }
}
```

## Remarks
If an unmanaged DLL file is included in an assembly, for example, by using the linker or the ```/linkresource``` compiler option, you can specify the assembly display name as part of ```dllName```. For example, if an unmanaged DLL named ```unmanaged.dll``` is included in a managed assembly named ```MyAssembly```, the attribute might be specified as shown in the following code.

```c#
[DllImport("unmanaged.dll, MyAssembly, Version= 1.0.0.0," +
    "Culture=neutral, PublicKeyToken=a77e0ba5eab10125")]
internal static extern int SomeFuncion1(int parm);
```


## Applies to

|Product|Versions
|---|---
|.Net|5.0, 6.0 Preview 3
|.NET Core|1.0, 1.1, 2.0, 2.1, 2.2, 3.0, 3.1
|.NET Framework|1.1, 2.0, 3.0, 3.5, 4.0, 4.5, 4.5.1, 4.5.2, 4.6, 4.6.1, 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8
|.NET Standard|1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 2.0, 2.1
|UWP|10.0
|Xamarin.Android|7.1
|Xamarin.iOS|10.8
|Xamarin.Mac|3.0
