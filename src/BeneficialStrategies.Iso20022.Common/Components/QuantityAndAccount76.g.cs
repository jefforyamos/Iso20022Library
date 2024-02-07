﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount76.  ISO2002 ID# _VMJU9c32Eee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the quantity, account and other related information involved in a transaction.
/// </summary>
public partial record QuantityAndAccount76
     : IIsoXmlSerilizable<QuantityAndAccount76>
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public Quantity10Choice_? SettlementQuantity { get; init; } 
    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    public IsoRestrictedFINXMax210Text? DenominationChoice { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification119? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccountIdentification6Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace2? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    public QuantityBreakdown48? QuantityBreakdown { get; init; } 
    
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
        if (SettlementQuantity is Quantity10Choice_ SettlementQuantityValue)
        {
            writer.WriteStartElement(null, "SttlmQty", xmlNamespace );
            SettlementQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DenominationChoice is IsoRestrictedFINXMax210Text DenominationChoiceValue)
        {
            writer.WriteStartElement(null, "DnmtnChc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax210Text(DenominationChoiceValue)); // data type RestrictedFINXMax210Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification119 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount30 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAccount is CashAccountIdentification6Choice_ CashAccountValue)
        {
            writer.WriteStartElement(null, "CshAcct", xmlNamespace );
            CashAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafeKeepingPlace2 SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuantityBreakdown is QuantityBreakdown48 QuantityBreakdownValue)
        {
            writer.WriteStartElement(null, "QtyBrkdwn", xmlNamespace );
            QuantityBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static QuantityAndAccount76 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
