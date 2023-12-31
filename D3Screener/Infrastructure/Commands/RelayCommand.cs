﻿using System.Windows.Input;

namespace D3Screener.Infrastructure.Commands
{
    internal class RelayCommand : Command
    {
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _canExecute;

        public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public override bool CanExecute(object? parameter)
        {
            if (_canExecute != null)
                return _canExecute(parameter);

            return true;
        }

        public override void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
