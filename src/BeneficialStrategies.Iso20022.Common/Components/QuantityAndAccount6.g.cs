﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityAndAccount6.  ISO2002 ID# _UbTrv9p-Ed-ak6NoX_4Aeg_1619096303.
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
public partial record QuantityAndAccount6
     : IIsoXmlSerilizable<QuantityAndAccount6>
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    public required Quantity6Choice_ SettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    public AmountAndDirection5? PreviouslySettledAmount { get; init; } 
    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    public AmountAndDirection5? RemainingToBeSettledAmount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification13Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    
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
        writer.WriteStartElement(null, "SttldQty", xmlNamespace );
        SettledQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PreviouslySettledQuantity is FinancialInstrumentQuantity1Choice_ PreviouslySettledQuantityValue)
        {
            writer.WriteStartElement(null, "PrevslySttldQty", xmlNamespace );
            PreviouslySettledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RemainingToBeSettledQuantity is FinancialInstrumentQuantity1Choice_ RemainingToBeSettledQuantityValue)
        {
            writer.WriteStartElement(null, "RmngToBeSttldQty", xmlNamespace );
            RemainingToBeSettledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviouslySettledAmount is AmountAndDirection5 PreviouslySettledAmountValue)
        {
            writer.WriteStartElement(null, "PrevslySttldAmt", xmlNamespace );
            PreviouslySettledAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RemainingToBeSettledAmount is AmountAndDirection5 RemainingToBeSettledAmountValue)
        {
            writer.WriteStartElement(null, "RmngToBeSttldAmt", xmlNamespace );
            RemainingToBeSettledAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification13Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CashAccount is CashAccountIdentification5Choice_ CashAccountValue)
        {
            writer.WriteStartElement(null, "CshAcct", xmlNamespace );
            CashAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormat3Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static QuantityAndAccount6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
