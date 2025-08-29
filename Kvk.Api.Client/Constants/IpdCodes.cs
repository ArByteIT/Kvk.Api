using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Kvk.Api.Client.Constants;

/// <summary>
/// https://developers.kvk.nl/nl/documentation#status-codes
/// </summary>
public class IpdCodes
{
    /// <summary>
    /// Het gevraagde product {0}
    /// </summary>
    public const string IPD0001 = "IPD0001";
    public const string IPD0004 = "IPD0004";
    public const string IPD0005 = "IPD0005";
    public const string IPD0006 = "IPD0006";
    public const string IPD0007 = "IPD0007";
    public const string IPD0010 = "IPD0010";
    public const string IPD1002 = "IPD1002";
    public const string IPD1003 = "IPD1003";
    public const string IPD1998 = "IPD1998";
    public const string IPD1999 = "IPD1999";
    public const string IPD5200 = "IPD5200";
    public const string IPD5203 = "IPD5203";
    public const string IPD9999 = "IPD9999";
}
