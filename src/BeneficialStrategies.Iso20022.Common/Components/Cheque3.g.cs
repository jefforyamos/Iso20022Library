﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cheque3.  ISO2002 ID# _QbdK-9p-Ed-ak6NoX_4Aeg_-241775444.
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
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_QbdK-9p-Ed-ak6NoX_4Aeg_-241775444")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cheque")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cheque3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Cheque3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Cheque3( PartyIdentification2Choice_ reqPayeeIdentification )
    {
        PayeeIdentification = reqPayeeIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
    /// </summary>
    [IsoId("_QbdK_Np-Ed-ak6NoX_4Aeg_-241775366")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Number { get; init; } 
    #else
    public System.String? Number { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    [IsoId("_QbdK_dp-Ed-ak6NoX_4Aeg_-241775384")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payee Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ PayeeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification2Choice_ PayeeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ PayeeIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_ PayeeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution on which a cheque is drawn, ie, the financial institution that services the account of the entity that issued the cheque.
    /// </summary>
    [IsoId("_QbdK_tp-Ed-ak6NoX_4Aeg_-241775426")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drawee Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification3Choice_? DraweeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification3Choice_? DraweeIdentification { get; init; } 
    #else
    public FinancialInstitutionIdentification3Choice_? DraweeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [IsoId("_QbmU4Np-Ed-ak6NoX_4Aeg_-241775434")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drawer Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? DrawerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? DrawerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? DrawerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
