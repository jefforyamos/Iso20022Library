﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCompensation1.  ISO2002 ID# _Uot1kdp-Ed-ak6NoX_4Aeg_-1569066973.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the securities compensation such as the depository and the total settlement amount.
/// </summary>
public partial record SecuritiesCompensation1
     : IIsoXmlSerilizable<SecuritiesCompensation1>
{
    #nullable enable
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    public required PartyIdentification34Choice_ Depository { get; init; } 
    /// <summary>
    /// Provides the total amount of money to be settled.
    /// </summary>
    public required AmountAndDirection20 SettlementAmount { get; init; } 
    /// <summary>
    /// Amount of money related to the fees for the securities compensation.
    /// </summary>
    public AmountAndDirection20? Fees { get; init; } 
    
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
        writer.WriteStartElement(null, "Dpstry", xmlNamespace );
        Depository.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
        SettlementAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Fees is AmountAndDirection20 FeesValue)
        {
            writer.WriteStartElement(null, "Fees", xmlNamespace );
            FeesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesCompensation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
