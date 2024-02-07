﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInformation2.  ISO2002 ID# _QIhn5tp-Ed-ak6NoX_4Aeg_-1159158700.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information required for the settlement the transaction.
/// </summary>
public partial record SettlementInformation2
     : IIsoXmlSerilizable<SettlementInformation2>
{
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    public required SettlementMethod2Code SettlementMethod { get; init; } 
    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    public CashAccount7? SettlementAccount { get; init; } 
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    public ClearingSystemIdentification1Choice_? ClearingSystem { get; init; } 
    
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
        writer.WriteStartElement(null, "SttlmMtd", xmlNamespace );
        writer.WriteValue(SettlementMethod.ToString()); // Enum value
        writer.WriteEndElement();
        if (SettlementAccount is CashAccount7 SettlementAccountValue)
        {
            writer.WriteStartElement(null, "SttlmAcct", xmlNamespace );
            SettlementAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingSystem is ClearingSystemIdentification1Choice_ ClearingSystemValue)
        {
            writer.WriteStartElement(null, "ClrSys", xmlNamespace );
            ClearingSystemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementInformation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
