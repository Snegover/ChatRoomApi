//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChatroomEmploee
    {
        public int id { get; set; }
        public Nullable<int> IdChatRoom { get; set; }
        public Nullable<int> idEmployee { get; set; }
    
        public virtual Chatroom Chatroom { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
