﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TotalNumber.  ISO2002 ID# _Qrsmadp-Ed-ak6NoX_4Aeg_-2040702072.
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
namespace BeneficialStrategies.Iso20022.Choices.NumberCount1Choice
{
    /// <summary>
    /// Total numbers of settlement transactions, receipts and deliveries, and the concerned settlement transaction number.
    /// </summary>
    [IsoId("_Qrsmadp-Ed-ak6NoX_4Aeg_-2040702072")]
    [DisplayName("Total Number")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TotalNumber : NumberCount1Choice_
    #else
    public partial class TotalNumber : NumberCount1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TotalNumber instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TotalNumber( System.String reqCurrentInstructionNumber,System.String reqTotalOfLinkedInstructions )
        {
            CurrentInstructionNumber = reqCurrentInstructionNumber;
            TotalOfLinkedInstructions = reqTotalOfLinkedInstructions;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sequential number of the instruction in a range of linked settlement instructions.
        /// </summary>
        [IsoId("_Qr_hWdp-Ed-ak6NoX_4Aeg_-2082263388")]
        [DisplayName("Current Instruction Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurInstrNb")]
        #endif
        [IsoXmlTag("CurInstrNb")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact3NumericText CurrentInstructionNumber { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String CurrentInstructionNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String CurrentInstructionNumber { get; init; } 
        #else
        public System.String CurrentInstructionNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Total number of settlement instructions that are linked together.
        /// </summary>
        [IsoId("_Qr_hWtp-Ed-ak6NoX_4Aeg_-1935589206")]
        [DisplayName("Total Of Linked Instructions")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TtlOfLkdInstrs")]
        #endif
        [IsoXmlTag("TtlOfLkdInstrs")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoExact3NumericText TotalOfLinkedInstructions { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TotalOfLinkedInstructions { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TotalOfLinkedInstructions { get; init; } 
        #else
        public System.String TotalOfLinkedInstructions { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
