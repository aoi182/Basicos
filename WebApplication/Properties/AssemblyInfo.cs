﻿using System.Reflection;
using System.Runtime.InteropServices;
using log4net.Config;

// La información general sobre un ensamblado se controla mediante el siguiente 
// conjunto de atributos. Cambie los valores de estos atributos para modificar la información
// asociada a un ensamblado.
[assembly: AssemblyTitle("WebApplication")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("WebApplication")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
// Let log4net know that it can look for configuration in the default application config file
[assembly: XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

// Si ComVisible se establece en false, los componentes COM no verán los 
// tipos de este ensamblado. Si necesita obtener acceso a un tipo de este ensamblado desde 
// COM, establezca el atributo ComVisible en true en este tipo.
[assembly: ComVisible(false)]

// El siguiente GUID es para el Id. typelib cuando este proyecto esté expuesto a COM
[assembly: Guid("ead3ba29-f3be-4a86-9d66-e70f40b7fad0")]

// La información de versión de un ensamblado consta de los siguientes cuatro valores:
//
//      Versión principal
//      Versión secundaria 
//      Número de compilación
//      Revisión
//
// Puede especificar todos los valores o usar los valores predeterminados de número de compilación y de revisión 
// mediante el carácter '*', como se muestra a continuación:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
