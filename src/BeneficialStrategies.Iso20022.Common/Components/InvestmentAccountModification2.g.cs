﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccountModification2.  ISO2002 ID# _X9WSMSFfEeW9XJWqfgXIIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the modification of an account.
/// </summary>
public partial record InvestmentAccountModification2
     : IIsoXmlSerilizable<InvestmentAccountModification2>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the modification to the investment account information.
    /// </summary>
    public IsoMax350Text? ModificationReason { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account modification request.
    /// </summary>
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    public AdditionalReference6? CounterpartyReference { get; init; } 
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    public IsoMax35Text? ExistingAccountIdentification { get; init; } 
    
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
        if (ModificationReason is IsoMax350Text ModificationReasonValue)
        {
            writer.WriteStartElement(null, "ModRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(ModificationReasonValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (AccountApplicationIdentification is IsoMax35Text AccountApplicationIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctApplId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountApplicationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CounterpartyReference is AdditionalReference6 CounterpartyReferenceValue)
        {
            writer.WriteStartElement(null, "CtrPtyRef", xmlNamespace );
            CounterpartyReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExistingAccountIdentification is IsoMax35Text ExistingAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "ExstgAcctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ExistingAccountIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static InvestmentAccountModification2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
