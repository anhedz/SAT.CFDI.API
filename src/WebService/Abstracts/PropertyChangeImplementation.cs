using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Jaeger.SAT.API.WebService.Abstracts {
    public abstract class PropertyChangeImplementation : INotifyPropertyChanged {
        protected PropertyChangeImplementation() {
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChangedEventHandler propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null) {
                propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression) {
            OnPropertyChanged(((MemberExpression)propertyExpression.Body).Member.Name);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
