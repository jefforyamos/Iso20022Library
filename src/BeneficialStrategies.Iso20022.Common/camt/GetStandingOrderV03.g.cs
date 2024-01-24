﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetStandingOrderV03.  ISO2002 ID# _jwlbnxbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope|The GetStandingOrder message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more standing orders, based on specific request criteria, especially to query the amount of the overall liquidity available. It will allow to query both reserved liquidity and liquidity available for normal operations.|Usage|The member can request information based on the following elements: |- individual standing orders (predefined or standing liquidity transfer orders)|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|This message will be answered by a ReturnStandingOrder message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The GetStandingOrder message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more standing orders, based on specific request criteria, especially to query the amount of the overall liquidity available. It will allow to query both reserved liquidity and liquidity available for normal operations.|Usage|The member can request information based on the following elements: |- individual standing orders (predefined or standing liquidity transfer orders)|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|This message will be answered by a ReturnStandingOrder message.")]
public partial record GetStandingOrderV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetStgOrdr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="GetStandingOrderV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetStandingOrderV03Document ToDocument()
    {
        return new GetStandingOrderV03Document { Message = this };
    }
}

/// <summary>
/// Scope|The GetStandingOrder message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more standing orders, based on specific request criteria, especially to query the amount of the overall liquidity available. It will allow to query both reserved liquidity and liquidity available for normal operations.|Usage|The member can request information based on the following elements: |- individual standing orders (predefined or standing liquidity transfer orders)|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|This message will be answered by a ReturnStandingOrder message.
/// This is the outer document that contains <seealso cref="GetStandingOrderV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record GetStandingOrderV03Document : IOuterDocument<GetStandingOrderV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.069.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="GetStandingOrderV03"/> is required.
    /// </summary>
    public required GetStandingOrderV03 Message { get; init; }
}
