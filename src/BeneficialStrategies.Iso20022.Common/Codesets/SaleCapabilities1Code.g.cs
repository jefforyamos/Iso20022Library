﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SaleCapabilities1Code.  ISO2002 ID# _hlgS8NtsEeiXqq0XHEoNUA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Hardware capabilities of the Sale Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hlgS8NtsEeiXqq0XHEoNUA")]
[Description(@"Hardware capabilities of the Sale Terminal.")]
[DerivedFrom(typeof(SaleCapabilitiesCode))]
public enum SaleCapabilities1Code
{
    /// <summary>
    /// Standard Cashier display interface (to ask question, or to show information). 
    /// Encoded/decoded by serializers as &quot;CHDI&quot;.
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_jUVMQdtsEeiXqq0XHEoNUA")]
    [Description(@"Standard Cashier display interface (to ask question, or to show information). ")]
    CashierDisplay = SaleCapabilitiesCode.CashierDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To display to the Cashier information related to an error situation occurring on the POI.
    /// Encoded/decoded by serializers as &quot;CHER&quot;.
    /// </summary>
    [EnumMember(Value = "CHER")]
    [IsoId("_jX0lIdtsEeiXqq0XHEoNUA")]
    [Description(@"To display to the Cashier information related to an error situation occurring on the POI.")]
    CashierError = SaleCapabilitiesCode.CashierError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.
    /// Encoded/decoded by serializers as &quot;CHIN&quot;.
    /// </summary>
    [EnumMember(Value = "CHIN")]
    [IsoId("_jbeWEdtsEeiXqq0XHEoNUA")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.")]
    CashierInput = SaleCapabilitiesCode.CashierInput, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To display to the Cashier a new state on which the POI is entering. 	For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.
    /// Encoded/decoded by serializers as &quot;CHST&quot;.
    /// </summary>
    [EnumMember(Value = "CHST")]
    [IsoId("_jeo-0dtsEeiXqq0XHEoNUA")]
    [Description(@"To display to the Cashier a new state on which the POI is entering. 	For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.")]
    CashierStatus = SaleCapabilitiesCode.CashierStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standard Customer display interface used by the POI System to ask question, or to show information to the Customer inside a Service dialogue.
    /// Encoded/decoded by serializers as &quot;CUDI&quot;.
    /// </summary>
    [EnumMember(Value = "CUDI")]
    [IsoId("_jr-3QdtsEeiXqq0XHEoNUA")]
    [Description(@"Standard Customer display interface used by the POI System to ask question, or to show information to the Customer inside a Service dialogue.")]
    CustomerDisplay = SaleCapabilitiesCode.CustomerDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.
    /// Encoded/decoded by serializers as &quot;CUAS&quot;.
    /// </summary>
    [EnumMember(Value = "CUAS")]
    [IsoId("_jvKuIdtsEeiXqq0XHEoNUA")]
    [Description(@"Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.")]
    CustomerAssistance = SaleCapabilitiesCode.CustomerAssistance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To display to the Customer information is related to an error situation occurring on the Sale Terminal during a Sale transaction.
    /// Encoded/decoded by serializers as &quot;CUER&quot;.
    /// </summary>
    [EnumMember(Value = "CUER")]
    [IsoId("_j2h6YdtsEeiXqq0XHEoNUA")]
    [Description(@"To display to the Customer information is related to an error situation occurring on the Sale Terminal during a Sale transaction.")]
    CustomerError = SaleCapabilitiesCode.CustomerError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).
    /// Encoded/decoded by serializers as &quot;CUIN&quot;.
    /// </summary>
    [EnumMember(Value = "CUIN")]
    [IsoId("_j6-VgdtsEeiXqq0XHEoNUA")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).")]
    CustomerInput = SaleCapabilitiesCode.CustomerInput, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information displayed on the Cardholder POI interface, replicated on the Cashier interface.
    /// Encoded/decoded by serializers as &quot;POIR&quot;.
    /// </summary>
    [EnumMember(Value = "POIR")]
    [IsoId("_j_1nYdtsEeiXqq0XHEoNUA")]
    [Description(@"Information displayed on the Cardholder POI interface, replicated on the Cashier interface.")]
    POIReplication = SaleCapabilitiesCode.POIReplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// When the POI System wants to print specific document (check, dynamic currency conversion ...).
    /// Encoded/decoded by serializers as &quot;PRDC&quot;.
    /// </summary>
    [EnumMember(Value = "PRDC")]
    [IsoId("_kFSIEdtsEeiXqq0XHEoNUA")]
    [Description(@"When the POI System wants to print specific document (check, dynamic currency conversion ...).")]
    PrinterDocument = SaleCapabilitiesCode.PrinterDocument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Printer for the Payment receipt.
    /// Encoded/decoded by serializers as &quot;PRRP&quot;.
    /// </summary>
    [EnumMember(Value = "PRRP")]
    [IsoId("_kJockdtsEeiXqq0XHEoNUA")]
    [Description(@"Printer for the Payment receipt.")]
    PrinterReceipt = SaleCapabilitiesCode.PrinterReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Coupons, voucher or special ticket generated by the POI and to be printed. 
    /// Encoded/decoded by serializers as &quot;PRVC&quot;.
    /// </summary>
    [EnumMember(Value = "PRVC")]
    [IsoId("_kOLlYdtsEeiXqq0XHEoNUA")]
    [Description(@"Coupons, voucher or special ticket generated by the POI and to be printed. ")]
    PrinterVoucher = SaleCapabilitiesCode.PrinterVoucher, // same ordinal as derivation source for type conversions
    
}
