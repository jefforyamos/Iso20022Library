﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalQueryParameters12.  ISO2002 ID# _8QboD5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific query criteria.
/// </summary>
public partial record AdditionalQueryParameters12
     : IIsoXmlSerilizable<AdditionalQueryParameters12>
{
    #nullable enable
    
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    public Status22Choice_? Status { get; init; } 
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    public Reason17Choice_? Reason { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Status is Status22Choice_ StatusValue)
        {
            writer.WriteStartElement(null, "Sts", xmlNamespace );
            StatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Reason is Reason17Choice_ ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            ReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentIdentification is SecurityIdentification20 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AdditionalQueryParameters12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
