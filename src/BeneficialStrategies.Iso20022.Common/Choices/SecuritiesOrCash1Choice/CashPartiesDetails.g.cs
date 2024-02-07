﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CashPartiesDetails.  ISO2002 ID# _yNcsADchEeOA3chqL9a4Rw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesOrCash1Choice;

/// <summary>
/// Cash settlement chain parties and accounts.
/// </summary>
public partial record CashPartiesDetails : SecuritiesOrCash1Choice_
     , IIsoXmlSerilizable<CashPartiesDetails>
{
    #nullable enable
    
    /// <summary>
    /// Party to which the payment amount must be ultimately delivered. In some cases, this may be a fund.
    /// </summary>
    public required PartyIdentificationAndAccount96 Creditor { get; init; } 
    /// <summary>
    /// Financial institution that services the cash account of the beneficiary (creditor). In some markets, this is also known as receiving agent. The creditor agent is the party where the payment amount must be ultimately delivered on behalf of the beneficiary (creditor), that is, the party where the beneficiary has its account.
    /// </summary>
    public required PartyIdentificationAndAccount97 CreditorAgent { get; init; } 
    /// <summary>
    /// Financial institution through which the transaction must pass to reach the account with institution (creditor agent).
    /// </summary>
    public PartyIdentificationAndAccount97? Intermediary { get; init; } 
    /// <summary>
    /// Financial institution through which the transaction must pass to reach the account with institution (creditor agent).
    /// </summary>
    public PartyIdentificationAndAccount97? Intermediary2 { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Cdtr", xmlNamespace );
        Creditor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
        CreditorAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Intermediary is PartyIdentificationAndAccount97 IntermediaryValue)
        {
            writer.WriteStartElement(null, "Intrmy", xmlNamespace );
            IntermediaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Intermediary2 is PartyIdentificationAndAccount97 Intermediary2Value)
        {
            writer.WriteStartElement(null, "Intrmy2", xmlNamespace );
            Intermediary2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new CashPartiesDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
