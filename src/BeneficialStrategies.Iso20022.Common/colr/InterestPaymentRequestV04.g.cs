﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InterestPaymentRequestV04.  ISO2002 ID# _CRyfcYFsEeWtPe6Crjmeug.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.colr;


/// <summary>
/// This record is an implementation of the colr.013.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The InterestPaymentRequest message is sent by either;
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager
/// It is used to request payment or advise the amount due for interest calculated for a specified period. The interest is based on the amount of collateral that has been held during the calculation period. It is possible to send these messages on a bi-lateral basis for matching.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The InterestPaymentRequest message is used to advise the interest amount calculated for a specific period or request payment for an interest amount for a specific period.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The InterestPaymentRequest message is sent by either;|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager|It is used to request payment or advise the amount due for interest calculated for a specified period. The interest is based on the amount of collateral that has been held during the calculation period. It is possible to send these messages on a bi-lateral basis for matching.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The InterestPaymentRequest message is used to advise the interest amount calculated for a specific period or request payment for an interest amount for a specific period.")]
public partial record InterestPaymentRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.013.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntrstPmtReq";
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_CRyfc4FsEeWtPe6Crjmeug")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required IsoMax35Text TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_CRyfdYFsEeWtPe6Crjmeug")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation4 Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_CRyfd4FsEeWtPe6Crjmeug")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    [Required]
    public required Agreement4 Agreement { get; init; }
    
    /// <summary>
    /// Provides details on the interest amount due to party A.
    /// </summary>
    [IsoId("_CRyfeYFsEeWtPe6Crjmeug")]
    [Description(@"Provides details on the interest amount due to party A.")]
    [DataMember(Name="IntrstDueToA")]
    [XmlElement(ElementName="IntrstDueToA")]
    public InterestAmount1? InterestDueToA { get; init; }
    
    /// <summary>
    /// Provides details on the interest amount due to party B.
    /// </summary>
    [IsoId("_CRyfe4FsEeWtPe6Crjmeug")]
    [Description(@"Provides details on the interest amount due to party B.")]
    [DataMember(Name="IntrstDueToB")]
    [XmlElement(ElementName="IntrstDueToB")]
    public InterestAmount1? InterestDueToB { get; init; }
    
    /// <summary>
    /// Provides the net interest amount due to A or due to B in case of collateral held and posted during a period.
    /// </summary>
    [IsoId("_CRyffYFsEeWtPe6Crjmeug")]
    [Description(@"Provides the net interest amount due to A or due to B in case of collateral held and posted during a period.")]
    [DataMember(Name="NetAmtDtls")]
    [XmlElement(ElementName="NetAmtDtls")]
    public InterestResult1? NetAmountDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_CRyff4FsEeWtPe6Crjmeug")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InterestPaymentRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InterestPaymentRequestV04Document ToDocument()
    {
        return new InterestPaymentRequestV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InterestPaymentRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InterestPaymentRequestV04Document : IOuterDocument<InterestPaymentRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.013.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InterestPaymentRequestV04"/> is required.
    /// </summary>
    public required InterestPaymentRequestV04 Message { get; init; }
}
