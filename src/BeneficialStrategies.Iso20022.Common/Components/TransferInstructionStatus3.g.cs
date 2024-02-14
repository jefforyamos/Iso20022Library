﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferInstructionStatus3.  ISO2002 ID# _aU1bMSGjEeONGJioFgcMDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction status.
/// </summary>
[IsoId("_aU1bMSGjEeONGJioFgcMDw")]
[DisplayName("Transfer Instruction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferInstructionStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferInstructionStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferInstructionStatus3( TransferStatus3Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_ar5QUyGjEeONGJioFgcMDw")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferStatus3Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferStatus3Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferStatus3Code Status { get; init; } 
    #else
    public TransferStatus3Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the status.
    /// </summary>
    [IsoId("_ar5QVSGjEeONGJioFgcMDw")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
