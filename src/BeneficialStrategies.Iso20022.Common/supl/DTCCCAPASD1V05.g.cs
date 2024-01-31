﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPASD1V05.  ISO2002 ID# _I7vFlZCEEeaSk9d1hvTrHg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// The DTCCCAPASD1 messge extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAPASD1 messge extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPASD1V05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";
    
    #nullable enable
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_I7vFl5CEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD25? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_I7vFn5CEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details.
    /// </summary>
    [IsoId("_I7vFoZCEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as supplementary data to corporate action balance details.")]
    [DataMember(Name="CorpActnBalDtls")]
    [XmlElement(ElementName="CorpActnBalDtls")]
    public CorporateActionBalanceSD3? CorporateActionBalanceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_I7vFo5CEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD8? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details securities quantity.
    /// </summary>
    [IsoId("_b3sdRNclEeaNRN5goVRSuw")]
    [Description(@"Information to be extended as supplementary data to corporate action details securities quantity.")]
    [DataMember(Name="SctiesQty")]
    [XmlElement(ElementName="SctiesQty")]
    public CorporateActionQuantitySD2? SecuritiesQuantity { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_I7vFpZCEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as corporate action movement securities movement details.")]
    [DataMember(Name="CorpActnMvmntSctiesMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntSctiesMvmntDtls")]
    public CorporateActionMovementSecuritiesMovementDetailsSD4? CorporateActionMovementSecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_I7vFrZCEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as corporate action movement cash movement details.")]
    [DataMember(Name="CorpActnMvmntCshMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntCshMvmntDtls")]
    public CorporateActionMovementCashMovementDetailsSD4? CorporateActionMovementCashMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_I_JTwJElEeajS_7NioJdVA")]
    [Description(@"Information to be extended as supplementary data to corporate action option details.")]
    [DataMember(Name="OptnTxDtls")]
    [XmlElement(ElementName="OptnTxDtls")]
    public OptionTransactionDetailsSD1? OptionTransactionDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPASD1V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPASD1V05Document ToDocument()
    {
        return new DTCCCAPASD1V05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAPASD1V05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAPASD1V05Document : IOuterDocument<DTCCCAPASD1V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPASD1V05"/> is required.
    /// </summary>
    public required DTCCCAPASD1V05 Message { get; init; }
}
