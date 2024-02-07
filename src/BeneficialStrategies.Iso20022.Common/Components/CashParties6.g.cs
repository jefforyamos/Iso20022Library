﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashParties6.  ISO2002 ID# _AzCb8NokEeC60axPepSq7g_650552270.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
public partial record CashParties6
     : IIsoXmlSerilizable<CashParties6>
{
    #nullable enable
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentificationAndAccount80? Debtor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public PartyIdentificationAndAccount80? DebtorAgent { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public PartyIdentificationAndAccount80? Creditor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public PartyIdentificationAndAccount80? CreditorAgent { get; init; } 
    
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
        if (Debtor is PartyIdentificationAndAccount80 DebtorValue)
        {
            writer.WriteStartElement(null, "Dbtr", xmlNamespace );
            DebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAgent is PartyIdentificationAndAccount80 DebtorAgentValue)
        {
            writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
            DebtorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Creditor is PartyIdentificationAndAccount80 CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is PartyIdentificationAndAccount80 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashParties6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
