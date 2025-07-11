﻿/*
 * Your rights to use code governed by this license http://o-s-a.net/doc/license_simple_engine.pdf
 * Ваши права на использование кода регулируются данной лицензией http://o-s-a.net/doc/license_simple_engine.pdf
*/

namespace OsEngine.Language
{
    public class OptimizerLocal
    {
        public string Title1 => OsLocalization.ConvertToLocString(
            "Eng:Index Tab Setup_" +
            "Ru:Настройка вкладки индекса_");

        public string Message1 => OsLocalization.ConvertToLocString(
            "Eng:The optimization process is already running._" +
            "Ru:Процесс оптимизации уже запущен_");

        public string Message2 => OsLocalization.ConvertToLocString(
            "Eng:Optimization process started_" +
            "Ru:Запущен процесс оптимизации_");

        public string Message3 => OsLocalization.ConvertToLocString(
            "Eng:Emergency completion requested. Wait for processes to stop_" +
            "Ru:Запрошено экстренное завершение оптимизации. Ждите остановки процессов_");

        public string Message4 => OsLocalization.ConvertToLocString(
            "Eng:Max count of bots for tests -_" +
            "Ru:Максимальное количество ботов для обхода-_");

        public string Message5 => OsLocalization.ConvertToLocString(
            "Eng:InSample stage is complete. Filtering data ..._" +
            "Ru:InSample этап закончен. Фильтруем данные..._");

        public string Message6 => OsLocalization.ConvertToLocString(
            "Eng:Filtering is over. We do forward tests ..._" +
            "Ru:Фильтрация окончена. Делаем форвардные тесты..._");

        public string Message7 => OsLocalization.ConvertToLocString(
            "Eng:Optimization complete_" +
            "Ru:Оптимизация закончена_");

        public string Message8 => OsLocalization.ConvertToLocString(
            "Eng:Unfortunately all bots were filtered. Set more benign settings to reject the results._" +
            "Ru:К сожалению все боты были отфильтрованы. Поставьте более щадящие настройки для выбраковки результатов_");

        public string Message9 => OsLocalization.ConvertToLocString(
            "Eng:Filtered bots -_" +
            "Ru:Отфильтрованно ботов -_");

        public string Message10 => OsLocalization.ConvertToLocString(
            "Eng:Too long waiting for the robot to connect to the data server. Something went wrong!_" +
            "Ru:Слишком долгое ожидание подклчючения робота к серверу данных. Что-то пошло не так!_");

        public string Message11 => OsLocalization.ConvertToLocString(
            "Eng:We start checking all strategies in the system for the presence of parameters_" +
            "Ru:Начинаем проверку всех стратегий в системе на наличие параметров_");

        public string Message12 => OsLocalization.ConvertToLocString(
            "Eng:The number of days in history is too small to optimize._" +
            "Ru:Число дней в истории слишком мало для оптимизации_");

        public string Message13 => OsLocalization.ConvertToLocString(
            "Eng:Too few days for so many phases_" +
            "Ru:Слишком малое кол-во дней для такого количества фаз_");

        public string Message14 => OsLocalization.ConvertToLocString(
            "Eng:Cannot start optimization. Not formed a sequence of steps._" +
            "Ru:Не возможно запустить оптимизацию. Не сформирована последовательность этапов._");

        public string Message15 => OsLocalization.ConvertToLocString(
            "Eng:Cannot start optimization. For the current robot, securities and timeframes in tabs are not selected._" +
            "Ru:Не возможно запустить оптимизацию. Для текущего робота не выбраны бумаги и таймфремы во вкладки._");

        public string Message16 => OsLocalization.ConvertToLocString(
            "Eng:Cannot start optimization. No data is available for testing_" +
            "Ru:Не возможно запустить оптимизацию. Не подключены данные для тестирования_");

        public string Message17 => OsLocalization.ConvertToLocString(
            "Eng:Cannot start optimization. No strategy selected._" +
            "Ru:Не возможно запустить оптимизацию. Не выбрана стратегия._");

        public string Message18 => OsLocalization.ConvertToLocString(
            "Eng:Cannot start optimization. No optimization options selected._" +
            "Ru:Не возможно запустить оптимизацию. Т.к. не выбран ни один параметр оптимизации._");

        public string Message19 => OsLocalization.ConvertToLocString(
            "Eng:Found strategies with parameters - _" +
            "Ru:Найдено стратегий с параметрами -_");

        public string Message20 => OsLocalization.ConvertToLocString(
            "Eng:Tab number _" +
            "Ru:№ вкладки_");

        public string Message21 => OsLocalization.ConvertToLocString(
            "Eng:Security _" +
            "Ru:Бумага_");

        public string Message22 => OsLocalization.ConvertToLocString(
            "Eng:Settings _" +
            "Ru:Настроить_");

        public string Message23 => OsLocalization.ConvertToLocString(
            "Eng:Step num_" +
            "Ru:№ шага_");

        public string Message24 => OsLocalization.ConvertToLocString(
            "Eng:Type_" +
            "Ru:Тип_");

        public string Message25 => OsLocalization.ConvertToLocString(
            "Eng:Start_" +
            "Ru:Начало_");

        public string Message26 => OsLocalization.ConvertToLocString(
            "Eng:End_" +
            "Ru:Конец_");

        public string Message27 => OsLocalization.ConvertToLocString(
            "Eng:Days_" +
            "Ru:Дней_");

        public string Message28 => OsLocalization.ConvertToLocString(
            "Eng:On/Off_" +
            "Ru:Вкл/Выкл_");

        public string Message29 => OsLocalization.ConvertToLocString(
            "Eng:Name_" +
            "Ru:Название_");

        public string Message30 => OsLocalization.ConvertToLocString(
            "Eng:Default_" +
            "Ru:По умолчанию_");

        public string Message31 => OsLocalization.ConvertToLocString(
            "Eng:Start value_" +
            "Ru:Стартовое значение_");

        public string Message32 => OsLocalization.ConvertToLocString(
            "Eng:Increment_" +
            "Ru:Шаг приращения_");

        public string Message33 => OsLocalization.ConvertToLocString(
            "Eng:End value_" +
            "Ru:Последнее значение_");

        public string Message34 => OsLocalization.ConvertToLocString(
            "Eng:Starting value can not be greater than the final_" +
            "Ru:Стартовое значение не может быть больше конечного_");

        public string Message35 => OsLocalization.ConvertToLocString(
            "Eng:Name_" +
            "Ru:Имя_");

        public string Message36 => OsLocalization.ConvertToLocString(
            "Eng:Profit in% to the deposit_" +
            "Ru:Профит в % к депо_");

        public string Message37 => OsLocalization.ConvertToLocString(
            "Eng:Average profit in %_" +
            "Ru:Профит в % на сделку");

        public string Message38 => OsLocalization.ConvertToLocString(
            "Eng:Params_" +
            "Ru:Параметры_");

        public string Message39 => OsLocalization.ConvertToLocString(
            "Eng:Journal_" +
            "Ru:Журнал_");

        public string Message40 => OsLocalization.ConvertToLocString(
            "Eng:Chart_" +
            "Ru:График_");

        public string Message41 => OsLocalization.ConvertToLocString(
            "Eng:Cannot start optimization. Parameter 'regime' is Off._" +
            "Ru:Не возможно запустить оптимизацию. Параметр 'regime' Off._");

        public string Message42 => OsLocalization.ConvertToLocString(
            "Eng:Params_" +
            "Ru:Параметры_");

        public string Message43 => OsLocalization.ConvertToLocString(
            "Eng:Cannot start optimization. Set timeFrame_" +
            "Ru:Не возможно запустить оптимизацию. Выберите таймфрейм_");

        public string Message44 => OsLocalization.ConvertToLocString(
            "Eng:Unable to start optimization. Wait for parameters to load._" +
            "Ru:Не возможно запустить оптимизацию. Подождите загрузки параметров_");

        public string Label1 => OsLocalization.ConvertToLocString(
            "Eng:Index securities_" +
            "Ru:Бумаги для индекса_");

        public string Label2 => OsLocalization.ConvertToLocString(
            "Eng:TimeFrame_" +
            "Ru:Таймфрейм_");

        public string Label3 => OsLocalization.ConvertToLocString(
            "Eng:Formula_" +
            "Ru:Формула_");

        public string Label4 => OsLocalization.ConvertToLocString(
            "Eng:Add_" +
            "Ru:Добавить_");

        public string Label5 => OsLocalization.ConvertToLocString(
            "Eng:Delete_" +
            "Ru:Удалить_");

        public string Label6 => OsLocalization.ConvertToLocString(
            "Eng:Accept_" +
            "Ru:Принять_");

        public string Label7 => OsLocalization.ConvertToLocString(
            "Eng:Progress_" +
            "Ru:Общий прогресс_");

        public string Label8 => OsLocalization.ConvertToLocString(
            "Eng:Threads_" +
            "Ru:Потоков_");

        public string Label9 => OsLocalization.ConvertToLocString(
            "Eng:Go!_" +
            "Ru:Погнали!_");

        public string Label10 => OsLocalization.ConvertToLocString(
            "Eng:Control_" +
            "Ru:Управление_");

        public string Label11 => OsLocalization.ConvertToLocString(
            "Eng:Data Server Settings_" +
            "Ru:Настройки сервера данных_");

        public string Label12 => OsLocalization.ConvertToLocString(
            "Eng:Optimization strategy_" +
            "Ru:Робот в оптимизацию_");

        public string Label13 => OsLocalization.ConvertToLocString(
            "Eng:Initial funds_" +
            "Ru:Начальные средства_");

        public string Label14 => OsLocalization.ConvertToLocString(
            "Eng:Sources and data_" +
            "Ru:Источники и данные_");

        public string Label15 => OsLocalization.ConvertToLocString(
            "Eng:Index_" +
            "Ru:Индексы_");

        public string Label16 => OsLocalization.ConvertToLocString(
            "Eng:Parameters_" +
            "Ru:Параметры_");

        public string Label17 => OsLocalization.ConvertToLocString(
            "Eng:Parameters table_" +
            "Ru:Таблица параметров_");

        public string Label18 => OsLocalization.ConvertToLocString(
            "Eng:Phases_" +
            "Ru:Этапы_");

        public string Label19 => OsLocalization.ConvertToLocString(
            "Eng:Create optimization scheme_" +
            "Ru:Создать схему оптимизации_");

        public string Label20 => OsLocalization.ConvertToLocString(
            "Eng:Test period_" +
            "Ru:Период для тестирования_");

        public string Label21 => OsLocalization.ConvertToLocString(
            "Eng:% of time OutOfSample_" +
            "Ru:% времени OutOfSample_");

        public string Label22 => OsLocalization.ConvertToLocString(
            "Eng:If the test results do not pass under the conditions, the run will be excluded from the general results._" +
            "Ru:Если результаты теста не будут проходить по условиям, то прогон будет исключён из общих результатов_");

        public string Label23 => OsLocalization.ConvertToLocString(
            "Eng:Filters_" +
            "Ru:Фильтры_");

        public string Label24 => OsLocalization.ConvertToLocString(
            "Eng:Profit in % of the deposit >_" +
            "Ru:Профит в % к депозиту >_");

        public string Label25 => OsLocalization.ConvertToLocString(
            "Eng:Maximum drawDown % >_" +
            "Ru:Максимальная просадка % >_");

        public string Label26 => OsLocalization.ConvertToLocString(
            "Eng:Average profit in % >_" +
            "Ru:Средняя прибыль в % >_");

        public string Label27 => OsLocalization.ConvertToLocString(
            "Eng:Profit deals in % >_" +
            "Ru:Выиграно сделок в % >_");

        public string Label28 => OsLocalization.ConvertToLocString(
            "Eng:Profit factor >_" +
            "Ru:Профит фактор >_");

        public string Label29 => OsLocalization.ConvertToLocString(
            "Eng:Results_" +
            "Ru:Результаты_");

        public string Label30 => OsLocalization.ConvertToLocString(
            "Eng:Optimization series_" +
            "Ru:Серия оптимизации_");

        public string Label31 => OsLocalization.ConvertToLocString(
            "Eng:Result table_" +
            "Ru:Таблица результатов_");

        public string Label32 => OsLocalization.ConvertToLocString(
            "Eng:Stop_" +
            "Ru:Остановить_");

        public string Label33 => OsLocalization.ConvertToLocString(
            "Eng:Previous data will be destroyed!_" +
            "Ru:Предыдущие данные будут уничтожены!_");

        public string Label34 => OsLocalization.ConvertToLocString(
            "Eng:Position count >_" +
            "Ru:Количество сделок >_");

        public string Label35 => OsLocalization.ConvertToLocString(
            "Eng:Select_" +
            "Ru:Выбрать_");

        public string Label36 => OsLocalization.ConvertToLocString(
            "Eng:Iteration count_" +
            "Ru:Кол-во итераций_");

        public string Label37=> OsLocalization.ConvertToLocString(
            "Eng:Series and Results_" +
            "Ru:Серии и результаты_");

        public string Label38 => OsLocalization.ConvertToLocString(
            "Eng:Out of sample statistic_" +
            "Ru:Статистика по Out of sample_");

        public string Label39 => OsLocalization.ConvertToLocString(
            "Eng:Sort by_" +
            "Ru:Метод сортировки_");       
        
        public string Label40 => OsLocalization.ConvertToLocString(
            "Eng:Commission Type_" +
            "Ru:Тип комиссии_");
        
        public string Label41 => OsLocalization.ConvertToLocString(
            "Eng:Commission Value_" +
            "Ru:Размер комиссии_");

        public string Label42 => OsLocalization.ConvertToLocString(
          "Eng:Last inSample_" +
          "Ru:Последний inSample_");

        public string Label43 => OsLocalization.ConvertToLocString(
          "Eng:Profit In OutOfSample %_" +
          "Ru:Прибыль в OutOfSample %_");

        public string Label44 => OsLocalization.ConvertToLocString(
          "Eng:3D map_" +
          "Ru:3D карта_");

        public string Label45 => OsLocalization.ConvertToLocString(
          "Eng:Save_" +
          "Ru:Сохранить_");

        public string Label46 => OsLocalization.ConvertToLocString(
          "Eng:Load_" +
          "Ru:Загрузить_");

        public string Label47 => OsLocalization.ConvertToLocString(
          "Eng:Max count of bots -_" +
          "Ru:Макс кол-во ботов -_");

        public string Label48 => OsLocalization.ConvertToLocString(
          "Eng:Reload_" +
          "Ru:Обновить_");

        public string Label49 => OsLocalization.ConvertToLocString(
          "Eng:Results_" +
          "Ru:Результаты_");

        public string Label50 => OsLocalization.ConvertToLocString(
          "Eng:In one of the optimization stages, less than one day. It is not possible to form an optimization sequence! Change the settings!_" +
          "Ru:В одном из этапов оптимизации менее одного дня. Сформировать последовательность оптимизации не получается! Измените настройки! _");

        public string Label51 => OsLocalization.ConvertToLocString(
          "Eng:Are you sure you want to interrupt the optimizer?_" +
          "Ru:Вы уверены в том что хотите прервать работу оптимизатора?_");

        public string Label52 => OsLocalization.ConvertToLocString(
             "Eng:The robot is being tested_" +
             "Ru:Робот тестируется_");

        public string Label53 => OsLocalization.ConvertToLocString(
             "Eng:Robustness metric: _" +
             "Ru:Показатель робастности: _");

        public string Label54 => OsLocalization.ConvertToLocString(
            "Eng:Total profit _" +
            "Ru:Итоговый профит _");

        public string Label55 => OsLocalization.ConvertToLocString(
           "Eng:Profit factor _" +
           "Ru:Профит фактор _");

        public string Label56 => OsLocalization.ConvertToLocString(
           "Eng:P/L % 1 contract _" +
           "Ru:П/У % 1 контракт _");

        public string Label57 => OsLocalization.ConvertToLocString(
           "Eng:Set Standard Params_" +
           "Ru:Вернуть стандартные параметры_");

        public string Label58 => OsLocalization.ConvertToLocString(
           "Eng:Number_" +
           "Ru:Номер_");

        public string Label59 => OsLocalization.ConvertToLocString(
           "Eng:Security_" +
           "Ru:Бумага_");

        public string Label60 => OsLocalization.ConvertToLocString(
           "Eng:The number of test robots is over a hundred thousand. It can take hours and days. Are you sure?_" +
           "Ru:Количество роботов для тестов больше ста тысяч. Это может затянуться на часы и дни. Вы уверены?_");

        public string Label61 => OsLocalization.ConvertToLocString(
           "Eng:When Walk-Forwards optimization, you need to turn off filters. But you have them turned on. This can cause errors. Are you sure? Do you want to continue?_" +
           "Ru:При Walk-Forwards оптимизации нужно отключать фильтры. Но у Вас они включены. Это может вызывать ошибки. Вы уверены? Хотите продолжить?_");
       
        public string Label62 => OsLocalization.ConvertToLocString(
           "Eng:Optimizer data storage_" +
           "Ru:Хранилище данных оптимизатора_");

        public string Label63 => OsLocalization.ConvertToLocString(
           "Eng:Time to end_" +
           "Ru:Время до конца_");

        public string Label64 => OsLocalization.ConvertToLocString(
           "Eng:Source type_" +
           "Ru:Тип источника_");

        public string Label65 => OsLocalization.ConvertToLocString(
           "Eng:First security_" +
           "Ru:Первая бумага_");

        public string Label66 => OsLocalization.ConvertToLocString(
           "Eng:Timeframe_" +
           "Ru:Таймфрейм_");

        public string Label67 => OsLocalization.ConvertToLocString(
           "Eng:Series result._" +
           "Ru:Результаты серии._");

        public string Label68 => OsLocalization.ConvertToLocString(
           "Eng:Bot_" +
           "Ru:Робот_");

        public string Label69 => OsLocalization.ConvertToLocString(
           "Eng:Value_" +
           "Ru:Значение_");
    }
}
