﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChequeDetails.  ISO2002 ID# _lDkQ0VNaEeijdq8ilaxyOA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument23Choice
{
    /// <summary>
    /// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
    /// </summary>
    [IsoId("_lDkQ0VNaEeijdq8ilaxyOA")]
    [DisplayName("Cheque Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ChequeDetails : PaymentInstrument23Choice_
    #else
    public partial class ChequeDetails : PaymentInstrument23Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ChequeDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ChequeDetails( PartyIdentification139 reqPayeeIdentification )
        {
            PayeeIdentification = reqPayeeIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for the cheque as assigned by the financial institution.
        /// </summary>
        [IsoId("_n8akcWAXEeiH9-hkDDXUHA")]
        [DisplayName("Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nb")]
        #endif
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Number { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Number { get; init; } 
        #else
        public System.String? Number { get; set; } 
        #endif
        
        /// <summary>
        /// Party to which the cheque is made payable.
        /// </summary>
        [IsoId("_n8akc2AXEeiH9-hkDDXUHA")]
        [DisplayName("Payee Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PyeeId")]
        #endif
        [IsoXmlTag("PyeeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification139 PayeeIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification139 PayeeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification139 PayeeIdentification { get; init; } 
        #else
        public PartyIdentification139 PayeeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution on which the cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
        /// </summary>
        [IsoId("_n8kVcGAXEeiH9-hkDDXUHA")]
        [DisplayName("Drawee Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrweeId")]
        #endif
        [IsoXmlTag("DrweeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification17? DraweeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification17? DraweeIdentification { get; init; } 
        #else
        public FinancialInstitutionIdentification17? DraweeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Account owner that issues the cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
        /// </summary>
        [IsoId("_n8kVcmAXEeiH9-hkDDXUHA")]
        [DisplayName("Drawer Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrwrId")]
        #endif
        [IsoXmlTag("DrwrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification139? DrawerIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification139? DrawerIdentification { get; init; } 
        #else
        public PartyIdentification139? DrawerIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
