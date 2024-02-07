﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CounterpartyIdentification12.  ISO2002 ID# _DrQZ4cg4Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
public partial record CounterpartyIdentification12
     : IIsoXmlSerilizable<CounterpartyIdentification12>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    public required PartyIdentification236Choice_ Identification { get; init; } 
    /// <summary>
    /// Identification of the branch of the counterparty, when the transaction concludes a transaction through a branch office.
    /// </summary>
    public Branch6Choice_? Branch { get; init; } 
    /// <summary>
    /// Country where the registered office of the counterparty is located or country of residence in case that the counterparty is a natural person.
    /// </summary>
    public CountryCode? CountryCode { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Branch is Branch6Choice_ BranchValue)
        {
            writer.WriteStartElement(null, "Brnch", xmlNamespace );
            BranchValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CountryCode is CountryCode CountryCodeValue)
        {
            writer.WriteStartElement(null, "CtryCd", xmlNamespace );
            writer.WriteValue(CountryCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CounterpartyIdentification12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
