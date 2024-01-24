﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ErrorHandlingCode.  ISO2002 ID# _ah3aSNp-Ed-ak6NoX_4Aeg_2042159796.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Error codes generated when the response to a query exceeds the maximum size or the data is not available.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ah3aSNp-Ed-ak6NoX_4Aeg_2042159796")]
[Description(@"Error codes generated when the response to a query exceeds the maximum size or the data is not available.")]
[Derivations(typeof(ErrorHandling1Code))]
public enum ErrorHandlingCode
{
    /// <summary>
    /// Specifies the error code when the data requested are not yet available.
    /// Encoded/decoded by serializers as "X020".
    /// </summary>
    [EnumMember(Value = "X020")]
    [IsoId("_aiBLQNp-Ed-ak6NoX_4Aeg_-1881551578")]
    [Description(@"Specifies the error code when the data requested are not yet available.")]
    DataNotYetAvailable,
    
    /// <summary>
    /// Specifies the error code when the data requested generates a message size that exceed the processing capacity.
    /// Encoded/decoded by serializers as "X030".
    /// </summary>
    [EnumMember(Value = "X030")]
    [IsoId("_aiBLQdp-Ed-ak6NoX_4Aeg_-1825215686")]
    [Description(@"Specifies the error code when the data requested generates a message size that exceed the processing capacity.")]
    MessageSizeLimitExceeded,
    
    /// <summary>
    /// Specifies the error code when the data requested have not been found.
    /// Encoded/decoded by serializers as "X050".
    /// </summary>
    [EnumMember(Value = "X050")]
    [IsoId("_aiBLQtp-Ed-ak6NoX_4Aeg_-1823370699")]
    [Description(@"Specifies the error code when the data requested have not been found.")]
    DataNotAvailable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ErrorHandlingCodeMetadataExtensions
{
    private static readonly ErrorHandlingCodeDropdownSource _dropdownSource = new ErrorHandlingCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IErrorHandlingCodeDropdownRow GetMetadata(this ErrorHandlingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


