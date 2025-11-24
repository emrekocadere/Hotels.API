interface CheckboxInputProps {
  name: string;
  checked: boolean;
  onChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
  label: React.ReactNode;
  error?: string;
}

const CheckboxInput = ({ name, checked, onChange, label, error }: CheckboxInputProps) => {
  return (
    <div>
      <label className="flex items-start cursor-pointer group">
        <input
          type="checkbox"
          name={name}
          checked={checked}
          onChange={onChange}
          className={`w-4 h-4 mt-1 border-slate-300 rounded focus:ring-2 focus:ring-slate-500 ${
            error ? 'border-red-400' : 'text-slate-700'
          }`}
        />
        <span className="ml-2 text-sm text-slate-600 group-hover:text-slate-900 transition-colors">
          {label}
        </span>
      </label>
      {error && (
        <p className="mt-2 text-sm text-red-600 font-medium">{error}</p>
      )}
    </div>
  );
};

export default CheckboxInput;
