/*
 * Copyright (c) 2003-2017 by AG-Software <info@ag-software.de>
 *
 * All Rights Reserved.
 * See the COPYING file for more information.
 *
 * This file is part of the MatriX project.
 *
 * NOTICE: All information contained herein is, and remains the property
 * of AG-Software and its suppliers, if any.
 * The intellectual and technical concepts contained herein are proprietary
 * to AG-Software and its suppliers and may be covered by German and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 *
 * Dissemination of this information or reproduction of this material
 * is strictly forbidden unless prior written permission is obtained
 * from AG-Software.
 *
 * Contact information for AG-Software is available at http://www.ag-software.de
 */

using Matrix.Xml;

namespace Matrix.Xmpp.Stream.Features
{
    public abstract class StreamFeature : XmppXElement
    {
        protected StreamFeature(string ns, string tagname)  : base(ns, tagname)
        {
        }

        /// <summary>
        /// Is this feature optional?
        /// </summary>
        public bool Optional
        {
            get { return HasTag("optional"); }
            set
            {
                if (value == false)
                    RemoveTag("optional");
                else
                    SetTag("optional");
            }
        }

        /// <summary>
        /// Is this feature required?
        /// </summary>
        public bool Required
        {
            get { return HasTag("required"); }
            set
            {
                if (value == false)
                    RemoveTag("required");
                else
                    SetTag("required");
            }
        }
    }
}
