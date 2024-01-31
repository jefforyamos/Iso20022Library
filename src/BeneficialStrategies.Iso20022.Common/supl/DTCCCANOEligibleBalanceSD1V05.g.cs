﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOEligibleBalanceSD1V05.  ISO2002 ID# _X0irV52EEeW-bsa36JFb9A.
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
/// This record is an implementation of the supl.007.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.")]
public partial record DTCCCANOEligibleBalanceSD1V05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.007.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOElgblBalSD1";
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_X0irWZ2EEeW-bsa36JFb9A")]
    [Description(@"Information to be extended as supplementary data to general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD21? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_X0irW52EEeW-bsa36JFb9A")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as account balance for distribution events.
    /// </summary>
    [IsoId("_X0irXZ2EEeW-bsa36JFb9A")]
    [Description(@"Extension block for the information to be extended as account balance for distribution events.")]
    [DataMember(Name="DstrbtnAcctBal")]
    [XmlElement(ElementName="DstrbtnAcctBal")]
    public AccountBalanceSD7? DistributionAccountBalance { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as account balance for redemptions events.
    /// </summary>
    [IsoId("_X0irX52EEeW-bsa36JFb9A")]
    [Description(@"Extension block for the information to be extended as account balance for redemptions events.")]
    [DataMember(Name="RedAcctBal")]
    [XmlElement(ElementName="RedAcctBal")]
    public AccountBalanceSD6? RedemptionAccountBalance { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOEligibleBalanceSD1V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOEligibleBalanceSD1V05Document ToDocument()
    {
        return new DTCCCANOEligibleBalanceSD1V05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOEligibleBalanceSD1V05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCANOEligibleBalanceSD1V05Document : IOuterDocument<DTCCCANOEligibleBalanceSD1V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.007.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOEligibleBalanceSD1V05"/> is required.
    /// </summary>
    public required DTCCCANOEligibleBalanceSD1V05 Message { get; init; }
}
