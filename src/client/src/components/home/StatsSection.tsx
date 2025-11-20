interface StatItemProps {
  value: string;
  label: string;
  color: string;
}

const StatItem = ({ value, label, color }: StatItemProps) => {
  return (
    <div>
      <div className={`text-4xl font-bold ${color} mb-2`}>{value}</div>
      <div className="text-slate-300">{label}</div>
    </div>
  );
};

const stats = [
  { value: '1000+', label: 'Hotels', color: 'text-blue-400' },
  { value: '50K+', label: 'Happy Customers', color: 'text-teal-400' },
  { value: '100+', label: 'Countries', color: 'text-amber-400' },
  { value: '24/7', label: 'Support', color: 'text-rose-400' }
];

const StatsSection = () => {
  return (
    <section className="bg-slate-700 text-white py-16 px-4">
      <div className="max-w-7xl mx-auto">
        <div className="grid md:grid-cols-4 gap-8 text-center">
          {stats.map((stat) => (
            <StatItem 
              key={stat.label}
              value={stat.value}
              label={stat.label}
              color={stat.color}
            />
          ))}
        </div>
      </div>
    </section>
  );
};

export default StatsSection;
