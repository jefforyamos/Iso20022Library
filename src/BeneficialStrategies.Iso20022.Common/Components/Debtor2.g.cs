﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Debtor2.  ISO2002 ID# _Urs4Jtp-Ed-ak6NoX_4Aeg_2065837485.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the debtor.
/// </summary>
public partial record Debtor2
     : IIsoXmlSerilizable<Debtor2>
{
    #nullable enable
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    public PartyIdentification2Choice_? Debtor { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentificationAndName3 AccountIdentification { get; init; } 
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// </summary>
    public required FinancialInstitutionIdentification3Choice_ FirstAgent { get; init; } 
    
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
        if (Debtor is PartyIdentification2Choice_ DebtorValue)
        {
            writer.WriteStartElement(null, "Dbtr", xmlNamespace );
            DebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AcctId", xmlNamespace );
        AccountIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FrstAgt", xmlNamespace );
        FirstAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Debtor2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
