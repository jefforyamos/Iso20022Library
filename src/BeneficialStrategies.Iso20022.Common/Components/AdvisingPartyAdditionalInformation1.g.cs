﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdvisingPartyAdditionalInformation1.  ISO2002 ID# _GBqPw34hEeG2Zfa6JvOQSQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information related to the advising party.
/// </summary>
public partial record AdvisingPartyAdditionalInformation1
     : IIsoXmlSerilizable<AdvisingPartyAdditionalInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned as a reference.
    /// </summary>
    public IsoMax35Text? ReferenceNumber { get; init; } 
    /// <summary>
    /// Additional information specific to the bank-to-beneficiary communication.
    /// </summary>
    public SimpleValueList<IsoMax2000Text> BankToBeneficiaryInformation { get; init; } = [];
    
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
        if (ReferenceNumber is IsoMax35Text ReferenceNumberValue)
        {
            writer.WriteStartElement(null, "RefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReferenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BkToBnfcryInf", xmlNamespace );
        BankToBeneficiaryInformation.Serialize(writer, xmlNamespace, "Max2000Text", SerializationFormatter.IsoMax2000Text );
        writer.WriteEndElement();
    }
    public static AdvisingPartyAdditionalInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
