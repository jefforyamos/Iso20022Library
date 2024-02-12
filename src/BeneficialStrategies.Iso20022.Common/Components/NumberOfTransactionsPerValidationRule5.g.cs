﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NumberOfTransactionsPerValidationRule5.  ISO2002 ID# _TiPqwcrdEeii_5g6VX90qQ.
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
/// Number of individual reports or transactions received / sent, detailed per validation rule.
/// </summary>
[IsoId("_TiPqwcrdEeii_5g6VX90qQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Number Of Transactions Per Validation Rule")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberOfTransactionsPerValidationRule5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberOfTransactionsPerValidationRule5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberOfTransactionsPerValidationRule5( System.String reqDetailedNumber )
    {
        DetailedNumber = reqDetailedNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual reports or transactions sent / received, detailed per status.
    /// </summary>
    [IsoId("_Tr7yQcrdEeii_5g6VX90qQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Detailed Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText DetailedNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String DetailedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DetailedNumber { get; init; } 
    #else
    public System.String DetailedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Common validation rule for all individual reports received.
    /// </summary>
    [IsoId("_Tr7yQ8rdEeii_5g6VX90qQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Report Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public RejectionReason45? ReportStatus { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Tr7yQ8rdEeii_5g6VX90qQ
    
    
    #nullable disable
    
}
