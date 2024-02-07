﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DirectDebitDetails.  ISO2002 ID# _VKiwQ9p-Ed-ak6NoX_4Aeg_-620434595.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument6Choice;

/// <summary>
/// Instruction, initiated by the creditor, to debit a debtor's account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor.
/// </summary>
public partial record DirectDebitDetails : PaymentInstrument6Choice_
     , IIsoXmlSerilizable<DirectDebitDetails>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required CashAccountIdentification1Choice_ DebtorAccountIdentification { get; init; } 
    /// <summary>
    /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
    /// </summary>
    public PartyIdentification2Choice_? DebtorIdentification { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    public PartyIdentification2Choice_? CreditorIdentification { get; init; } 
    /// <summary>
    /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
    /// </summary>
    public required FinancialInstitutionIdentification3Choice_ FirstAgent { get; init; } 
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
    /// </summary>
    public FinancialInstitutionIdentification3Choice_? FinalAgent { get; init; } 
    /// <summary>
    /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
    /// </summary>
    public IsoMax35Text? RegistrationIdentification { get; init; } 
    /// <summary>
    /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
    /// </summary>
    public IsoMax35Text? MandateIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "DbtrAcctId", xmlNamespace );
        DebtorAccountIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DebtorIdentification is PartyIdentification2Choice_ DebtorIdentificationValue)
        {
            writer.WriteStartElement(null, "DbtrId", xmlNamespace );
            DebtorIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorIdentification is PartyIdentification2Choice_ CreditorIdentificationValue)
        {
            writer.WriteStartElement(null, "CdtrId", xmlNamespace );
            CreditorIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FrstAgt", xmlNamespace );
        FirstAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinalAgent is FinancialInstitutionIdentification3Choice_ FinalAgentValue)
        {
            writer.WriteStartElement(null, "FnlAgt", xmlNamespace );
            FinalAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationIdentification is IsoMax35Text RegistrationIdentificationValue)
        {
            writer.WriteStartElement(null, "RegnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RegistrationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MandateIdentification is IsoMax35Text MandateIdentificationValue)
        {
            writer.WriteStartElement(null, "MndtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MandateIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new DirectDebitDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
