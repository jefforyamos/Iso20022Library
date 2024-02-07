﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionQuantity14.  ISO2002 ID# _p4XbMzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action quantities.
/// </summary>
public partial record CorporateActionQuantity14
     : IIsoXmlSerilizable<CorporateActionQuantity14>
{
    #nullable enable
    
    /// <summary>
    /// The maximum number of securities the offeror/issuer is ready to purchase or redeem. This can be a number or the term "any and all".
    /// </summary>
    public FinancialInstrumentQuantity44Choice_? MaximumQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity of securities the offeror/issuer is ready to purchase or redeem under the terms of the event. This can be a number or the term "any and all".
    /// </summary>
    public FinancialInstrumentQuantity44Choice_? MinimumQuantitySought { get; init; } 
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    public FinancialInstrumentQuantity43Choice_? NewBoardLotQuantity { get; init; } 
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    public FinancialInstrumentQuantity43Choice_? NewDenominationQuantity { get; init; } 
    /// <summary>
    /// Minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    public FinancialInstrumentQuantity43Choice_? BaseDenomination { get; init; } 
    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    public FinancialInstrumentQuantity43Choice_? IncrementalDenomination { get; init; } 
    
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
        if (MaximumQuantity is FinancialInstrumentQuantity44Choice_ MaximumQuantityValue)
        {
            writer.WriteStartElement(null, "MaxQty", xmlNamespace );
            MaximumQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumQuantitySought is FinancialInstrumentQuantity44Choice_ MinimumQuantitySoughtValue)
        {
            writer.WriteStartElement(null, "MinQtySght", xmlNamespace );
            MinimumQuantitySoughtValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewBoardLotQuantity is FinancialInstrumentQuantity43Choice_ NewBoardLotQuantityValue)
        {
            writer.WriteStartElement(null, "NewBrdLotQty", xmlNamespace );
            NewBoardLotQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewDenominationQuantity is FinancialInstrumentQuantity43Choice_ NewDenominationQuantityValue)
        {
            writer.WriteStartElement(null, "NewDnmtnQty", xmlNamespace );
            NewDenominationQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BaseDenomination is FinancialInstrumentQuantity43Choice_ BaseDenominationValue)
        {
            writer.WriteStartElement(null, "BaseDnmtn", xmlNamespace );
            BaseDenominationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IncrementalDenomination is FinancialInstrumentQuantity43Choice_ IncrementalDenominationValue)
        {
            writer.WriteStartElement(null, "IncrmtlDnmtn", xmlNamespace );
            IncrementalDenominationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionQuantity14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
